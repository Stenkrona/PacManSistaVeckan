using UnityEngine;
using System.Collections;

public class OnBonusItem : MonoBehaviour {

	private GameObject pacMan;
	private GameBrain gb;

	private float time;
	private float min;
	private float max;


	void Start () {

		time = 0f;

		pacMan = GameObject.Find ("PacMan");
		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	
	}
	void Update()
	{

		time = time + Time.deltaTime;
		min = 7f;
		max = 11f;

		if(time >= Random.Range(min, max))
		{
			Destroy(gameObject);
		}



	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == pacMan.name)
		{
		gb.ScoreBonus();
		Destroy(gameObject);
		}
	}
}
