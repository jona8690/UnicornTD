﻿using UnityEngine;
using System.Collections;

public class MainMenuBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButton(0))
        {
            GameManager.instance.ChangeState(GameManager.GameState.START);
        }
	}
}
