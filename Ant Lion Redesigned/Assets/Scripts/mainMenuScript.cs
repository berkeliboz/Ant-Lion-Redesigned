using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour {

    public globalState globalState;

    public Animator anim;

    public void chooseEasy() {
        globalState.difficulty = globalState.Difficulty.EASY;
        SceneManager.LoadScene(1);
    }
    public void chooseMedium()
    {
        globalState.difficulty = globalState.Difficulty.MEDIUM;
        SceneManager.LoadScene(1);
    }
    public void chooseHard()
    {
        globalState.difficulty = globalState.Difficulty.HARD;
        SceneManager.LoadScene(1);
    }

    public void playButton() {
        anim.Play("gui_movement");
    }
    
}
