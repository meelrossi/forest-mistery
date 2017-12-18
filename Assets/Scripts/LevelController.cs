using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SimpleJSON;

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
		string filePath = Path.Combine(Application.dataPath, levelDataFolder + LevelInfo.Level + ".json");
		if (File.Exists(filePath))
		{
			string dataAsJson = File.ReadAllText(filePath);
			var json = JSON.Parse(dataAsJson);
			List<Question> questions = new List<Question>();
			for (int i = 0; i < json["questions"].AsArray.Count; i++)
			{
				var each = json["questions"][i];
				List<string> options = new List<string>();
				for (int j = 0; j < each["options"].AsArray.Count; j++)
				{
					options.Add(each["options"][j]);
				}
				Question q = new Question(each["title"], each["question"], options, each["answer"], each["clue"]);
				questions.Add(q);
			}
			level = new Level(json["name"], questions, json["final_puzzle"]);
			FinalQuestionPanel.instance.setAnswer(json["final_puzzle"]);
		}
	}
}
