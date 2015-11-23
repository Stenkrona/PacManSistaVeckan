using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject resumeButton; //knappen för Resume.
	public GameObject mainMenuButton; // Knapp för Main Menu.
	public GameObject shade;

	public GameObject text; // Text som består av " Pause".

	private GameBrain gameover; //ska peka på GameBrain Componenten i GameBrain Objectet.
	public bool state; //en variabel som är till för att toggla ett GameObject av eller på i Metoden EnableDis.
	private GameObject[] ghosts;

	void Start()
	{
		state = true;
		gameover = GameObject.Find("GameBrain").GetComponent<GameBrain>();
		ghosts = GameObject.FindGameObjectsWithTag("Enemy");
	}


	void Update () {

		if(gameover.IsGameOver() == false) // Kollar om spelet är över eller inte, är det inte det kan man pausa spelet.
		{
				if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P)) // Pausa spelet med esc eller P.
				{
						for (int i = 0; i < ghosts.Length; i++)
						{
							ghosts[i].GetComponent<GhostMovement>().GamePaused();
						}

					new ToggleTheTime(); // Gör så att unity tiden stannar så det händer inget.
					new EnableDis(resumeButton); // Sätter på några knappar och text som ska synas under pausen.
					new EnableDis(text);
					new EnableDis(mainMenuButton);
					new EnableDis(shade);
				    

				}
		}
	
	}
		
	public void Resume() //Tar bort alla pause relaterade object och sätter igång spelet.
	{
		for (int i = 0; i < ghosts.Length; i++){
			ghosts[i].GetComponent<GhostMovement>().GamePaused();
		}

		new ToggleTheTime();
		new EnableDis(resumeButton);
		new EnableDis(text);
		new EnableDis(mainMenuButton);
		new EnableDis(shade);
	}
	
}
