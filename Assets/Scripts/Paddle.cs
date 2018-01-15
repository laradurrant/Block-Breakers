using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	Vector3 paddlePosition;
	float mousePos;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		paddlePosition = new Vector3(0f, -6.5f, 0f);
		mousePos = Input.mousePosition.x / Screen.width;
		paddlePosition.x = mousePos * 19f;
		this.transform.position = paddlePosition;

		transform.position = new Vector3 (Mathf.Clamp (paddlePosition.x, 0, 19f), -6.5f, 0);
			

		//debugFunctions ();


	}


	void debugFunctions()
	{

		print (paddlePosition.x + " " + paddlePosition.y);
		print ("Screen width: " + Screen.width * 5);
		print ("Mouse x pos: " + Input.mousePosition);
		print ("Mouse Position: " + mousePos);
		print ("Paddle Position x: " + paddlePosition.x);

	}



}
