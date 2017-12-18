using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionPanel : MonoBehaviour {

	public static QuestionPanel instance = null;
	public Text title;
	public Text question;
	public Text option1;
	public Text option2;
	public Text option3;
	public Text option4;

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
	}

	public void setQuestion(Question q)
	{
		gameObject.SetActive(true);
		title.text = q.title;
		question.text = q.question;
		option1.text = q.options[0];
		option2.text = q.options[1];
		option3.text = q.options[2];
		option4.text = q.options[3];
	}
}
