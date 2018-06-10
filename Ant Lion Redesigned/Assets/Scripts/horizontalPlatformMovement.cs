using System.Collections;
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
        speed = 10;
        range = randomRangeGenerator();
    }
	
	// Update is called once per frame
	void Update () {
        obj.transform.position = new Vector2(Mathf.Sin(counter * (speed/100)) *range, obj.transform.position.y);
        counter++;
           
    }

    int randomSpeedGenerator() {
        return Random.Range(0, 16);
    }

    float randomRangeGenerator() {
        return (float)(Random.Range(0,21)-10)/5;
    }

}
