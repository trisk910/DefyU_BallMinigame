﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartArk : MonoBehaviour {

	private GameManager score;
	private GameManager formations;
	//private GameManager keepscore;
	//private Arbrito arb;


	// Use this for initialization
	void Start () {
		score = FindObjectOfType<GameManager>();
		formations = FindObjectOfType<GameManager>();
		//keepscore = FindObjectOfType<GameManager>();
		//arb = FindObjectOfType<Arbrito>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnMouseDown(){			

			Input.ResetInputAxes ();
			//GameManager.Instance.isMenu = false;

			GameManager.arbrito = true;

			score.score -= GameManager.oldScore;
			GameManager.oldScore = 0;
			GameManager.Instance.nextFormation ();

	}
}
