﻿using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour {
    float distanceToPacman;
    
    public Transform pacManPos;    
    public Transform ghost;
    public Transform spawnPoint;
    public Transform[] points;

    private int destPoint = 0;
    NavMeshAgent ghostAgent;

	private bool isGamePaused;
  

    void Start () {
        ghostAgent = GetComponent<NavMeshAgent>();
        ghostAgent.autoBraking = false;
        Patrol();
		isGamePaused = false;
    }

	void Update () {

		if(isGamePaused == false)
		{
			        distanceToPacman = Vector3.Distance(ghost.position, pacManPos.position);
			        if (distanceToPacman < 7.0f) {
			            ghostAgent.destination = pacManPos.position;
			        }
			        else if (ghostAgent.remainingDistance < 0.5f)
			        {
			            Patrol();
			        }
		}
		else
		{
			ghostAgent.destination = transform.position;
		}
            
    }

    public void RespawnGhosts() {
        // ghostAgent = GetComponent<NavMeshAgent>();
        ghost.position = spawnPoint.position;

    }


    void Patrol()
    {
        // Set the agent to go to the currently selected destination.
        ghostAgent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }
	public void GamePaused()
	{
		isGamePaused = !isGamePaused;
	}
}
