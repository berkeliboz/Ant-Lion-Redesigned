﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalPlatformMovement : MonoBehaviour {

    private GameObject obj;
    public float counter = 0;
    public float range = 0.5f;
    public float speed = 10;
	// Use this for initialization
	void Start () {
        obj = this.gameObject;
        speed = randomSpeedGenerator();
        range = randomRangeGenerator();
    }
	
	// Update is called once per frame
	void Update () {
        obj.transform.position = new Vector2(Mathf.Sin(counter * (speed/ 1000)) *range, obj.transform.position.y);
        counter++;
        
        


    }

    float randomSpeedGenerator() {
        return ((float)Random.Range(0, 10) )/ 10;
    }

    float randomRangeGenerator() {
        return (float)(Random.Range(0,21))/5;
    }

}
