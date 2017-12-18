using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class QuestionPanel : MonoBehaviour {

	public static QuestionPanel instance = null;
	public Text title;
	public Text question;
	public Toggle option1;
	public Toggle option2;
	public Toggle option3;
	public Toggle option4;

	public ToggleGroup group;

	public Button continueButton;
	public Button confirmButton;

	List<Toggle> options = new List<Toggle>();
	public Question currentQuestion;

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
		gameObject.SetActive(false);
		options.Add(option1);
		options.Add(option2);
		options.Add(option3);
		options.Add(option4);
	}

	public void setQuestion(Question q)
	{

		confirmButton.gameObject.SetActive(true);
		continueButton.gameObject.SetActive(false);
		gameObject.SetActive(true);
		currentQuestion = q;

		title.text = q.title;
		question.text = q.question;
		option1.GetComponentInChildren<Text>().text = q.options[0];
		option2.GetComponentInChildren<Text>().text = q.options[1];
		option3.GetComponentInChildren<Text>().text = q.options[2];
		option4.GetComponentInChildren<Text>().text = q.options[3];
	}

	public void SubmitAnswer()
	{
		Toggle selected = group.ActiveToggles().FirstOrDefault();
		confirmButton.gameObject.SetActive(false);
		continueButton.gameObject.SetActive(true);
		if (selected.tag == (currentQuestion.answer + ""))
		{
			selected.GetComponentInChildren<Text>().color = Color.green;
			ForestMisteryController.instance.CorrectAnswer();
		}
		else {
			selected.GetComponentInChildren<Text>().color = Color.red;
			options[currentQuestion.answer].GetComponentInChildren<Text>().color = Color.green;
			ForestMisteryController.instance.WrongAnswer();
		}
	}

	public void Continue()
	{
		Toggle selected = group.ActiveToggles().FirstOrDefault();
		selected.GetComponentInChildren<Text>().color = Color.white;
		options[currentQuestion.answer].GetComponentInChildren<Text>().color = Color.white;
		group.SetAllTogglesOff();
		gameObject.SetActive(false);
	}
}
