using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private bool collides = false;
    private Rigidbody2D playerRigidbody;
    public int jumpingSpeed = 1;
    

	void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
       
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "platform")
           collides = true;
    }

    void OnCollisionExit2D(Collision2D other) {
        collides = false;

    }


    void FixedUpdate() {
        if (Input.GetKeyDown("space")&&collides)
            playerRigidbody.AddForce(new Vector2(0, 1 * jumpingSpeed));

        if (playerRigidbody.velocity.y < 0) {
            playerRigidbody.AddForce(new Vector2(0,4));

        }

        

    }

    // Update is called once per frame
    void Update () {
            
        
	}
}
