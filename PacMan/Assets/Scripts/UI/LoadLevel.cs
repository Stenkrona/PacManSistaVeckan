using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour { 





	public void LoadL()  //hämtar den level med det nr.
	{ 
		DontDestroyOnLoad(GameObject.Find("GameBrain"));
		Application.LoadLevel(Application.loadedLevel + 1);


		Time.timeScale = 1f; //Så att tiden inte är pausad när man kommer till scenen.
		//GameObject.Find ("GameBrain").GetComponent<GameBrain>().WhatStage();

	}

	public void ReloadLevel() //Laddar om banan som man är på.
	{
		int loadedLevel = Application.loadedLevel;
		GameObject.Find("GameBrain").GetComponent<AudioSource>().Stop();
		GameObject.Find("GameBrain").GetComponent<AudioSource>().Play ();
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().WhatStage();
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().Reset();
		Time.timeScale = 1f;

		Application.LoadLevel(loadedLevel);
	}
	public void LoadMainMenu()
	{
		Destroy(GameObject.Find("GameBrain"));
		Application.LoadLevel(0);
	}
}
