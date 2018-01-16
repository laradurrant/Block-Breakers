﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	
	private Vector3 paddleToBallVector; 
	public Rigidbody2D rb;
	public float thrust = 10;
	private bool GameInSession = false;
	
	
	void Start()
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;	
		print(paddleToBallVector);
	}
	
	void Update()
	{
		if(!GameInSession)
		{
			this.transform.position = paddle.transform.position + paddleToBallVector + Vector3.right;
		
		
			if(Input.GetMouseButtonUp(0))
			{
				GameInSession = true;
				print("Mouse clicked!");
					
				float x, y;
				
				x = Random.Range(-2f,2f);
				y = Random.Range(9f,10f);
				
				rb.velocity = new Vector2 (x, y);
			
			}
		
		}
		
		
	}
	
}
