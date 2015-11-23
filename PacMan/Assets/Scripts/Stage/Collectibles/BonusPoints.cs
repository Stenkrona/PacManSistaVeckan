using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BonusPoints : MonoBehaviour {

	public List<Transform> locations; //Platser där frukter kan spawna;
	public List<GameObject> bonusItems; // GameObjects som är frukter. Man kan använda sig utav hur många man vill.
	public List<Sprite> numbers; //
	
	private int r;
	private int i;
	public int d;

	private GameBrain gb;

	public float time;
	public float randomTime;

	private float min;
	private float max;
	


	void Start () {

		min = 15;
		max = 25;
		d = GameObject.FindGameObjectsWithTag("Dot").Length;

		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	
	}
	

	void Update () {

		randomTime = Random.Range(min,max);

		time = gb.WhatTime();

		if(time >= randomTime && gb.HowManyDots() <= d)
		{
			Debug.Log ("hej");
			SpawnBonusPoints();
			ChangeTerms();
		}

	
	}
	public void SpawnBonusPoints()
	{
		r = Random.Range(0,9);
		i = Random.Range(0, bonusItems.Count);

		Instantiate(bonusItems[i], locations[r].position, new Quaternion(0f, 180f, 0f, 0f)); //Spawna frukten bakochfram. 


	}
	void ChangeTerms()
	{
		d = d - 50;

		min = min + 20f;
		max = max + 20f;
	}
}
