using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clothingScript : MonoBehaviour
{

    public Sprite currentSkin;
    public GameObject player;
   

    public void toggleHat()
    {
        Image hat = GameObject.Find("Hat").GetComponent<Image>();
        if (hat.color == new Color32(255, 255, 255, 255)) {
            hat.color = new Color32(255, 255, 255, 0);
            PlayerPrefs.SetInt("hat", 0);
        }
        else
        {
            hat.color = new Color32(255, 255, 255, 255);
            PlayerPrefs.SetInt("hat", 1);
        }
    }
    public void toggleShirt()
    {
        Image hat = GameObject.Find("Shirt").GetComponent<Image>();
        if (hat.color == new Color32(255, 255, 255, 255)) {
            hat.color = new Color32(255, 255, 255, 0);
            PlayerPrefs.SetInt("shirt", 0);
        }
        else
        {
            hat.color = new Color32(255, 255, 255, 255);
            PlayerPrefs.SetInt("shirt", 1);
        }
    }
    public void toggleShirt2()
    {
        Image hat = GameObject.Find("Shirt_2").GetComponent<Image>();
        if (hat.color == new Color32(255, 255, 255, 255)) {
            hat.color = new Color32(255, 255, 255, 0);
            PlayerPrefs.SetInt("shirt2", 0);
        }
        
        else
        {
            hat.color = new Color32(255, 255, 255, 255);
            PlayerPrefs.SetInt("shirt2", 1);
        }
    }
    public void toggleGlasses()
    {
        Image hat = GameObject.Find("Glasses").GetComponent<Image>();
        if (hat.color == new Color32(255, 255, 255, 255)) {
            PlayerPrefs.SetInt("glasses", 0);
            hat.color = new Color32(255, 255, 255, 0);
        
        }
        else
        {
            hat.color = new Color32(255, 255, 255, 255);
            PlayerPrefs.SetInt("glasses", 1);
        }
    }

}
