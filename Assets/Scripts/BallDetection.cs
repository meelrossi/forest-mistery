using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

	public GameObject cube;
	bool canInteract = false;
	bool alreadyVisited = false;

	void Start () {
		cube.SetActive (false);
	}

	void OnTriggerEnter(Collider other) {
		if (!alreadyVisited && other.gameObject.CompareTag("boy"))
		{
			cube.SetActive(true);
			canInteract = true;
			ForestMisteryController.instance.interactImage.SetActive(true);
		}

	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("boy"))
		{
			cube.SetActive(false);
			canInteract = false;
			ForestMisteryController.instance.interactImage.SetActive(false);
		}

	}

	void FixedUpdate() {
		if (Input.GetKey ("e") && canInteract && !alreadyVisited && !ForestMisteryController.instance.allQuestionsAnswered()) {
			alreadyVisited = true;
			QuestionPanel.instance.setQuestion(LevelController.instance.level.questions[ForestMisteryController.instance.answeredQuestions]);
			ForestMisteryController.instance.interactImage.SetActive(false);
			taskCompleted();
		}
	}

	void taskCompleted() {
		cube.SetActive(false);
	}
}
