using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	Vector3 paddlePosition;
	float mousePos;
	public bool autoPlay = false;
	private Ball ball; 
	
	void Start()
	{
		 ball = GameObject.FindObjectOfType<Ball>();
		
	}
	

	// Update is called once per frame
	void Update () {

		if(!autoPlay)
		{
			MoveWithMouse();
		}
		else
		{
			AutoPlay();
		}

		//debugFunctions ();


	}

	void AutoPlay()
	{
		paddlePosition = new Vector3(0f, -6.5f, 0f);
		Vector3 offset = new Vector3(1.0f, 0f, 0f);
		
		Vector3 ballPos = ball.transform.position - offset;
		
		
		
		paddlePosition.x = mousePos * 20f;
		this.transform.position = paddlePosition + offset;

		transform.position = new Vector3 (Mathf.Clamp (ballPos.x, 5.5f, 26f), -6.5f, 0);
	}
	
	void MoveWithMouse()
	{
		
		paddlePosition = new Vector3(10.5f, -6.5f, 0f);
		mousePos = Input.mousePosition.x / Screen.width;
		//float middle = Screen.width / 2f;
		
		
		paddlePosition.x = mousePos * 30f + 0.5f;
		this.transform.position = paddlePosition;

		
		transform.position = new Vector3 (Mathf.Clamp (paddlePosition.x, 5.5f, 26f), -6.5f, 0);
	
		debugFunctions();
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
