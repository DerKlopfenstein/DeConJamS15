﻿using UnityEngine;
using System.Collections;

public class CreditsScript1 : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.anyKeyDown)
        {
            Application.Quit();
            Debug.Log("Exiting lol");
        }
	}
}
