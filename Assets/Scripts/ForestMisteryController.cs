using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestMisteryController : MonoBehaviour {

	public static ForestMisteryController instance = null;
	
	int score;
	Level level;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Start()
	{
		score = 0;
		LevelController.instance.LoadLevelData();
	}
}
