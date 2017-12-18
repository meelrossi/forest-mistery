using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForestMisteryController : MonoBehaviour {

	public static ForestMisteryController instance = null;

	public Text answeredQuestionsText;
	public Text scoreText;
	public int answeredQuestions;
	public GameObject winPanel;
	public GameObject losePanel;
	public GameObject searchImage;
	public GameObject interactImage;
	
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
		scoreText.text = "PUNTOS: " + score;
		answeredQuestions = 0;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
		winPanel.SetActive(false);
		losePanel.SetActive(false);
		searchImage.SetActive(false);
		interactImage.SetActive(false);
	}

	public void resetPanels()
	{
		searchImage.SetActive(false);
		FinalQuestionPanel.instance.gameObject.SetActive(false);
	}

	public void CorrectAnswer()
	{
		answeredQuestions += 1;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
		score += 10;
		scoreText.text = "PUNTOS: " + score;
		if (answeredQuestions == LevelController.instance.level.questions.Count)
		{
			searchImage.SetActive(true);
		}
	}

	public void WrongAnswer()
	{
		answeredQuestions += 1;
		answeredQuestionsText.text = answeredQuestions + "/" + LevelController.instance.level.questions.Count;
		if (answeredQuestions == LevelController.instance.level.questions.Count)
		{
			searchImage.SetActive(true);
		}
	}


	public bool allQuestionsAnswered()
	{
		return answeredQuestions == LevelController.instance.level.questions.Count;
	}


	public void winGame()
	{
		winPanel.SetActive(true);
		resetPanels();
	}

	public void loseGame()
	{
		losePanel.SetActive(true);
		resetPanels();
	}
}
