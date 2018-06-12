﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    private GameObject enemy;
    int counter = 0;
    float speed = 0.01f;
    float range = 0.8f;
	// Use this for initialization
	void Start () {
        enemy = this.gameObject;


	}

    

    // Update is called once per frame
    void FixedUpdate () {
        enemy.transform.position = new Vector2(Mathf.Sin(counter * (speed)) * range, enemy.transform.position.y);
        counter++;


    }
}
