using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

	public string[] quotes;

	void Start () {

		gameObject.GetComponent<Text>().text = quotes[Random.Range (0, quotes.Length)];
	}

}
