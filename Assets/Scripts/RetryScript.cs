﻿using UnityEngine;
using System.Collections;

public class RetryScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BeginNewGame()
    {
        Application.LoadLevel("Game");
    }
}
