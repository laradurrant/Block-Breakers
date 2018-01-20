using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	
	private Vector3 paddleToBallVector; 
	public Rigidbody2D rb;
	public float thrust = 10;
	private bool GameInSession = false;
	public AudioSource audio;
	
	
	
	void Start()
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;	
		//print(paddleToBallVector);
		GameInSession = false;
		
	}
	
	void Update()
	{
		if(!GameInSession)
		{
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
		
			if(Input.GetMouseButtonUp(0))
			{
				GameInSession = true;
				print("Mouse clicked!");
					
				float x, y;
				
				x = 2f;
				y = Random.Range(10f,11f);
				
				rb.velocity = new Vector2 (x, y);
				
			}
		
		}
		
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		Vector2 tweak = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
		
		//print(collision.gameObject);
		if(GameInSession)
		{
		//	audio.Play();
			rb.velocity += tweak;
		}
		
	}
	
	
}


