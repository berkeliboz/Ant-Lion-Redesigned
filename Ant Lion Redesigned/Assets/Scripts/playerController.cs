using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour
{
    public bool isPoweredUp = false;
    public bool hit = false;
    public bool collides = false;


    private Rigidbody2D playerRigidbody;
    private Transform playerTransform;
    public float jumpingSpeed = 1;
    public float horizontalSpeed = 1f;
    private float movement = 0f;
    public Text debugger;


    public int hp = 5;
    private GameObject stateObj;
    private globalState state;
    public Text hpText;

    private float hitCounter = 1f;

    public float powC = 2f;
    
    public Sprite[] skins;                                      //Attach skins here !!!

    public int counter = 0;

    private SpriteRenderer srComp;                              //Sprite Renderer here !!!

    public Sprite playerImage;

    void Start()
    {

        stateObj = GameObject.Find("GlobalState");
        state = stateObj.GetComponent<globalState>();



        if (state.difficulty == globalState.Difficulty.EASY)
        {
            hp = 5;
        }
        else if (state.difficulty == globalState.Difficulty.MEDIUM)
        {
            hp = 3;
        }
        else if (state.difficulty == globalState.Difficulty.HARD)
        {
            hp = 1;
        }


        srComp = this.GetComponent<SpriteRenderer>();

        srComp.sprite = skins[PlayerPrefs.GetInt("skin")];
        //srComp.sprite = skins[4];
        //Debug.Log(PlayerPrefs.GetInt("skins"));
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        Screen.orientation = ScreenOrientation.Portrait;

    }

    void hitCount()
    {

        if (hit)
        {
            hitCounter -= Time.deltaTime;
            Debug.Log(hitCounter);
            if (hitCounter <= 0)
            {
                hitCounter = 2f;
                hit = false;
            }
        }
    }

    void poweredUpCounter()
    {
        if (isPoweredUp)
        {

            powC -= Time.deltaTime;
            if (powC <= 0)
            {
                powC = 2f;
                isPoweredUp = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "platform")
            collides = true;

        if (col.collider.tag == "powerupJump")
        {
            isPoweredUp = true;
            playerRigidbody.AddForce(new Vector2(0, 3 * jumpingSpeed));

        }
        if (col.collider.tag == "enemy")
        {

            if (!isPoweredUp && !hit)
            {
                hit = true;
                hp -= 1;
                playerTransform.position = new Vector2(playerTransform.position.x, playerTransform.position.y - 1);
            }



        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        collides = false;

    }

    bool handleTouch()
    {
        try
        {
            
            if (Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                    return true;
            }
        }
        catch
        {
        }
        return false;
    }

    void FixedUpdate()
    {
        poweredUpCounter();
        playerTransform.eulerAngles = new Vector2(playerTransform.eulerAngles.x, 0);
        playerRigidbody.freezeRotation = true;


        if (playerTransform.position.x >= 3)
        {
            playerTransform.position = new Vector2(-3, playerTransform.position.y);
        }

        if (playerTransform.position.x < -3)
        {
            playerTransform.position = new Vector2(2.8f, playerTransform.position.y);
        }




        if ((Input.GetKeyDown("space") || handleTouch()) && collides)
        {
            playerRigidbody.AddForce(new Vector2(0, 2 * jumpingSpeed));


        }
        hitCount();
       

        if (!collides)
            horizontalSpeed = 1;
        else
            horizontalSpeed = 0.5f;


        Vector2 velocity = playerRigidbody.velocity;
        velocity.x = movement * horizontalSpeed;

        playerRigidbody.velocity = velocity;




    }


    void Update()
    {
        //movement = Input.GetAxis("Horizontal");                           //Uncomment this line for PC input
        movement = Input.acceleration.x * 5;                                  //Uncomment this line for Android input

        hpText.text = hp.ToString();

        if (hp <= 0)
        {
            SceneManager.LoadScene(0);
        }

        
    }
}
