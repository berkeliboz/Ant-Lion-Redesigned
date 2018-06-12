using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {

    private GameObject basePlatform;
    public int lenght = 10;
    public float platformDistance = 1f;

    ArrayList platformList = new ArrayList();

    private GameObject stateObj;
    private globalState state;

	void Start () {
        basePlatform = this.gameObject;
        stateObj = GameObject.Find("GlobalState");
        state = stateObj.GetComponent<globalState>();
        setLevelDifficulty();


        for (int i = 0; i < lenght; i++)
        {
            Vector2 oldPos = new Vector2(basePlatform.transform.position.x + randPlatformXLocation(), basePlatform.transform.position.y + 2*(i+ platformDistance));
            GameObject newPlatform = Instantiate(Resources.Load(randPlatformChooser()), oldPos , basePlatform.transform.rotation) as GameObject;
            platformList.Add(newPlatform); //Not used 
        }
    }

    public string randPlatformChooser() {
        int lvl = state.level.ToString()[3]-48;         //This line of code will crush after level9 is added!!
        Debug.Log(lvl);
        return Random.Range(0,  lvl+3).ToString();
            
    }
        

    
    public float randPlatformXLocation() {
        int randNum = (Random.Range(0, 21) - 10);
        return (float)randNum/10;
    }



    public void setLevelDifficulty() {
        if (state.difficulty == globalState.Difficulty.EASY) {
            lenght = 20;
        }
        else if (state.difficulty == globalState.Difficulty.MEDIUM)
        {
            lenght = 100;
        }
        else if(state.difficulty == globalState.Difficulty.HARD) {
            lenght = 200;
        }

    }

}
