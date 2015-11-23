using UnityEngine;
using System.Collections;

public class DotCounts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().Reset();
		new ToggleTheTime();
	
	}

}
