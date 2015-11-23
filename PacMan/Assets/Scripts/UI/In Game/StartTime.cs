using UnityEngine;
using System.Collections;

public class StartTime : MonoBehaviour {//töntigt litet script som sätter igång tiden.

	void Start()
	{
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().StopMusic();
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().WhatStage();

		new ToggleTheTime();
	}
}
