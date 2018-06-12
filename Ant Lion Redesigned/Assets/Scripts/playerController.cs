using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public bool collides = false;
    private Rigidbody2D playerRigidbody;
    private Transform playerTransform;
    public float jumpingSpeed = 1;
    public float horizontalSpeed = 1f;
    private float movement = 0f;
    public Text debugger;

    public Sprite[] skins;                                      //Attach skins here !!!

    public int counter = 0;

    private SpriteRenderer srComp;                              //Sprite Renderer here !!!

	void Start () {
        srComp = this.GetComponent<SpriteRenderer>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        Screen.orientation = ScreenOrientation.Portrait;
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "platform")
           collides = true;

        if (col.collider.tag == "powerupJump")
            playerRigidbody.AddForce(new Vector2(0, 3 * jumpingSpeed));
    }

    void OnCollisionExit2D(Collision2D other) {
        collides = false;

    }

    bool handleTouch() {
        try {
            if(Input.GetTouch(0).tapCount > 0)
                return true;
        }
        catch {
            }
        return false;
    }

    void FixedUpdate() {

        playerTransform.eulerAngles = new Vector2(playerTransform.eulerAngles.x, 0);
        playerRigidbody.freezeRotation = true;
        

        if (playerTransform.position.x >= 3) {
            playerTransform.position = new Vector2(-3, playerTransform.position.y);
        }

        if (playerTransform.position.x < -3)
        {
           playerTransform.position = new Vector2(2.8f, playerTransform.position.y);
        }




        if ((Input.GetKeyDown("space")|| handleTouch()) && collides) {
            playerRigidbody.AddForce(new Vector2(0, 1 * jumpingSpeed));
        

        }

        if (playerRigidbody.velocity.y < 0) {
            playerRigidbody.AddForce(new Vector2(0,4));

        }

        if (!collides)
            horizontalSpeed = 1;
        else
            horizontalSpeed = 0.5f;

        
        Vector2 velocity = playerRigidbody.velocity;
        velocity.x = movement*horizontalSpeed;
        
        playerRigidbody.velocity = velocity;
        


        
    }


    void Update () {
        //movement = Input.GetAxis("Horizontal");                           //Uncomment this line for PC input
        movement = Input.acceleration.x*5;                                  //Uncomment this line for Android input
        debugger.text = Input.acceleration.x.ToString();

       

    }
}
