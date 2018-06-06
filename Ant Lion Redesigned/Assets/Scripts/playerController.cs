using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private bool collides = false;
    private Rigidbody2D playerRigidbody;
    private Transform playerTransform;
    public int jumpingSpeed = 1;
    public int horizontalSpeed = 1;
    private float movement = 0f;

	void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
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

        playerTransform.eulerAngles = new Vector2(playerTransform.eulerAngles.x, 0);

        if (Input.GetKeyDown("space")&&collides)
            playerRigidbody.AddForce(new Vector2(0, 1 * jumpingSpeed));

        if (playerRigidbody.velocity.y < 0) {
            playerRigidbody.AddForce(new Vector2(0,4));

        }

        if (!collides) {
            Vector2 velocity = playerRigidbody.velocity;
            velocity.x = movement*horizontalSpeed;
            playerRigidbody.velocity = velocity;

        }





    }

    // Update is called once per frame
    void Update () {
        movement = Input.GetAxis("Horizontal");

    }
}
