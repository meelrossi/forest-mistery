using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForestMisteryController : MonoBehaviour {

	public static ForestMisteryController instance = null;

	public Text answeredQuestionsText;
	public int answeredQuestions;
	public GameObject winPanel;
	
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
		LevelController.instance.LoadLevelData();
		score = 0;
		answeredQuestions = 0;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
		winPanel.SetActive(false);
	}

	public void CorrectAnswer()
	{
		answeredQuestions += 1;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
		score += 10;
	}

	public void WrongAnswer()
	{
		answeredQuestions += 1;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
	}


	public bool allQuestionsAnswered()
	{
		return answeredQuestions == LevelController.instance.level.questions.Count;
	}

}
