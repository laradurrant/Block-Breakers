using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public static int brickCount = 0;
	private bool isBreakable; 
	
	
	public int maxHits = 0;
	private int timesHit;
	private LevelManager levelmanager;
	public Sprite[] hitSprites;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		timesHit = 0;

		if(isBreakable)
		{
			brickCount++;
		}
		
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		Debug.Log(brickCount);
	}
	

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Collision");
		timesHit++;
		
		
		if(isBreakable)
		{
			HandleHits();
		}
	}
	
	void HandleHits()
	{
						
			if(timesHit >= maxHits)
			{
				//SimulateWin();
				
				Destroy(gameObject);
			
				brickCount--;
				Debug.Log(brickCount);
				
				if(brickCount <= 0)
				{
				SimulateWin();
				}	
			}
			else{
				LoadSprites();
			}
	}
	
	void LoadSprites()
	{
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		
	}
	
	void SimulateWin()
	{
		levelmanager.LoadNextLevel();
	}
}
