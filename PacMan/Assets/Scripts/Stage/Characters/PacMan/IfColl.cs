using UnityEngine;
using System.Collections;

public class IfColl : MonoBehaviour
{
    private float speed = 5.0f;
    private float rayCastDistance = 0.5f;
    public bool moveForward = true;
    public bool moveBack = true;
    public bool moveLeft = true;
    public bool moveRight = true;

    void Update()
    {
        MovingOn();
        MovePlayer();
    }

    void MovingOn()
    {
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			if (Physics.Raycast(transform.position, fwd, rayCastDistance)) {
				print("There is something in front of the object!");
				moveForward = false;}
			else
				moveForward = true;
		

			Vector3 bck = transform.TransformDirection(Vector3.back);
			if (Physics.Raycast(transform.position, bck, rayCastDistance)) {
				print("There is something behind of the object!");
			moveBack = false;}
		else
			moveBack = true;

			Vector3 lft = transform.TransformDirection(Vector3.left);
			if (Physics.Raycast(transform.position, lft, rayCastDistance)) {
				print("There is something on the left of the object!");
				moveLeft = false;}
		else
			moveLeft = true;

			Vector3 rgt = transform.TransformDirection(Vector3.right);
			if (Physics.Raycast(transform.position, rgt, rayCastDistance)) {
				print("There is something on the right of the object!");
				moveRight = false;}
		else
			moveRight = true;
    }

		void MovePlayer()
    {
        if (moveForward == true)
                if (Input.GetKey(KeyCode.W))
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (moveBack == true)
            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (moveLeft == true)
            if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (moveRight == true)
            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
	

}