using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits = 0;
	private int timesHit;
	private LevelManager levelmanager;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Collision");
		timesHit++;
		
		if(timesHit >= maxHits)
		{
			SimulateWin();
			Destroy(gameObject);
			
		}
	}
	
	void SimulateWin()
	{
		levelmanager.LoadNextLevel();
	}
}
