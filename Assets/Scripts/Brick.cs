using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits = 0;
	private int timesHit;
	private LevelManager levelmanager;
	public Sprite[] hitSprites;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Collision");
		timesHit++;
		
		if(timesHit >= maxHits)
		{
			//SimulateWin();
			Destroy(gameObject);
			
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
