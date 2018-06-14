using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class customizationScreenButton : MonoBehaviour
{

    Image player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Image>();
    }

    public void switchSkin()
    {
        player.sprite = this.GetComponent<Image>().sprite;

        if (player.sprite.name == "Antlion Assets_3")
        {
            PlayerPrefs.SetInt("skin", 0);
        }
        else if (player.sprite.name == "Antlion Assets_4")
        {
            PlayerPrefs.SetInt("skin", 1);
        }
        else if (player.sprite.name == "Antlion Assets_5")
        {
            PlayerPrefs.SetInt("skin", 3);
        }
        else if (player.sprite.name == "Antlion Assets_9")
        {
            PlayerPrefs.SetInt("skin", 4);
        }
    }
}