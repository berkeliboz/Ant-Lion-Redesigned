using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalState : MonoBehaviour {

    public enum Difficulty { EASY, MEDIUM, HARD };
    public Difficulty difficulty;

    public enum Skins {skin1, skin2, skin3, skin4, skin5 }
    

    // Use this for initialization
    void Start()
    {
        Object.DontDestroyOnLoad(this);
        difficulty = Difficulty.MEDIUM;
    }

}
