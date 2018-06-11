using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {

    private GameObject basePlatform;
    public int lenght = 10;
    public float platformDistance = 1f;

    ArrayList platformList = new ArrayList();


	void Start () {
        basePlatform = this.gameObject;

        for (int i = 0; i < lenght; i++)
        {
            Vector2 oldPos = new Vector2(basePlatform.transform.position.x + randPlatformXLocation(), basePlatform.transform.position.y + 2*(i+ platformDistance));
            GameObject newPlatform = Instantiate(Resources.Load(randPlatformChooser()), oldPos , basePlatform.transform.rotation) as GameObject;
            platformList.Add(newPlatform); //Not used
        }
    }

    public string randPlatformChooser() {
        return Random.Range(0, 6).ToString();
    }

    public float randPlatformXLocation() {
        int randNum = (Random.Range(0, 21) - 10);
        return (float)randNum/10;
    }

}
