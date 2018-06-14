using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpCode : MonoBehaviour {

    public GameObject[] hpImages;
    private GameObject playerRef;

    private int hp;
	// Use this for initialization
	void Start () {
        playerRef = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        hp = playerRef.GetComponent<playerController>().hp;
        for (int i = 0; i < 5-hp; i++) {
            hpImages[i].SetActive(false);
        }

    }
}
