using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelController : MonoBehaviour {


	public static LevelController instance = null;

	private string levelDataFolder = "data/";

	public Level level;

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

	public void LoadLevelData () {
		string filePath = Path.Combine(Application.dataPath, levelDataFolder);

		if (File.Exists(filePath))
		{
			string dataAsJson = File.ReadAllText(filePath);
			level = JsonUtility.FromJson<Level>(dataAsJson);
		}
	}
}
