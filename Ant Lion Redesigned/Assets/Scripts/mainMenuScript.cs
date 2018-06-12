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
        anim.Play("level_selection_movement");

    }
    public void chooseMedium()
    {
        globalState.difficulty = globalState.Difficulty.MEDIUM;
        anim.Play("level_selection_movement");

    }
    public void chooseHard()
    {
        globalState.difficulty = globalState.Difficulty.HARD;
        anim.Play("level_selection_movement");

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

    public void chooseLevel1() {
        SceneManager.LoadScene(3);
        globalState.level = globalState.LevelNames.lvl1;
    }
    public void chooseLevel2()
    {
        SceneManager.LoadScene(4);
        globalState.level = globalState.LevelNames.lvl2;
    }
    public void chooseLevel3()
    {
        SceneManager.LoadScene(5);
        globalState.level = globalState.LevelNames.lvl3;
    }
    public void chooseLevel4()
    {
        SceneManager.LoadScene(6);
        globalState.level = globalState.LevelNames.lvl4;
    }



}
