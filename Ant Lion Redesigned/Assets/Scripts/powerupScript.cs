using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupScript : MonoBehaviour {

    private GameObject powerup;

	// Use this for initialization
	void Start () {
        powerup = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
            Destroy(gameObject);

    }


}
