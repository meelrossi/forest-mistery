using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalQuestionPanel : MonoBehaviour {

	public static FinalQuestionPanel instance = null;

	public InputField answer;

	string correctAnswer;

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

	void Start () {
		gameObject.SetActive(false);
	}

	public void setAnswer(string ans)
	{
		correctAnswer = ans;
	}

	public void openPanel()
	{
		gameObject.SetActive(true);
	}

	public void onSubmit()
	{
		if (answer.text.ToLower() == correctAnswer.ToLower())
		{
			ForestMisteryController.instance.winGame();
		}
		else {
			ForestMisteryController.instance.loseGame();
		}
		
	}
}
