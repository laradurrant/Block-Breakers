﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits = 0;
	private int timesHit;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Collision");
		timesHit++;
		
		if(timesHit > maxHits)
		{
			Destroy(gameObject);
		}
	}
}
