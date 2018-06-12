using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour {

    public globalState globalState;

    public Animator anim;
    public Animator inventoryButtonAnimator;


    public void chooseEasy() {
        globalState.difficulty = globalState.Difficulty.EASY;
        SceneManager.LoadScene(3);
    }
    public void chooseMedium()
    {
        globalState.difficulty = globalState.Difficulty.MEDIUM;
        SceneManager.LoadScene(3);
    }
    public void chooseHard()
    {
        globalState.difficulty = globalState.Difficulty.HARD;
        SceneManager.LoadScene(3);
    }

    public void playButton() {
        anim.Play("gui_movement");
    }

    public void inventoryButton() {
        inventoryButtonAnimator.Play("inventory_movement");

    }
    public void inventoryButtonBack()
    {
        inventoryButtonAnimator.Play("inventory_movement_back");

    }




}
