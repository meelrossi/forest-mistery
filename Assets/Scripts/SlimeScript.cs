using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour {

	public GameObject notYetPanel;
	public GameObject cube;

	public bool questionValidation;

	bool canInteract = false;

	void Start () {
		cube.SetActive(false);
		notYetPanel.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		cube.SetActive(true);
		canInteract = true;

	}

	void OnTriggerExit(Collider other)
	{
		cube.SetActive(false);
		notYetPanel.SetActive(false);
		canInteract = false;
	}

	void FixedUpdate()
	{
		if (Input.GetKey("e") && canInteract)
		{
			if (ForestMisteryController.instance.allQuestionsAnswered() || !questionValidation)
			{
				QuestionPanel.instance.setQuestion(LevelController.instance.level.questions[ForestMisteryController.instance.answeredQuestions]);
				cube.SetActive(false);
			}
			else {
				notYetPanel.SetActive(true);
			}

		}
	}
}
