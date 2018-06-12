using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalPlatformMovement : MonoBehaviour {

    private GameObject obj;
    public float counter = 0;
    public float range = 0.5f;
    public float speed = 10;

    private GameObject stateObj;
    private globalState state;


    void Start () {
        obj = this.gameObject;

        stateObj = GameObject.Find("GlobalState");
        state = stateObj.GetComponent<globalState>();



        randomSpeedGenerator();
        
        

    }
	

	void Update () {
        obj.transform.position = new Vector2(Mathf.Sin(counter * (speed/ 1000)) *range, obj.transform.position.y);
        counter++;
 
    }

    void randomSpeedGenerator() {

        if (state.difficulty == globalState.Difficulty.EASY)
        {
            speed = 10;
            range = 0.5F;
        }
        else if (state.difficulty == globalState.Difficulty.MEDIUM)
        {
            speed = 50;
            range = 1F;
        }
        else if (state.difficulty == globalState.Difficulty.HARD)
        {
            speed = 100;
            range = 2F;
        }
    }

    float randomRangeGenerator() {
        return (float)(Random.Range(0,21))/5;
    }

}
