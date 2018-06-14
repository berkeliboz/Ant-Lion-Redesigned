using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antlionCode : MonoBehaviour {

    public GameObject antlion;

	// Use this for initialization
	void Start () {
        antlion = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        antlion.transform.position = new Vector2(antlion.transform.position.x, antlion.transform.position.y + Time.deltaTime);
	}
}
