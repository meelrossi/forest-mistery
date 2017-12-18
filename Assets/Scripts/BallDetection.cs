using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

	public GameObject cube;
	public string animation;
	bool canInteract = false;
	bool alreadyVisited = false;


	private Animation anim;

	void Start () {
		cube.SetActive (false);
		anim = GetComponent<Animation> ();
	}

	void OnTriggerEnter(Collider other) {
		if (!alreadyVisited)
		{
			cube.SetActive(true);
			canInteract = true;
		}

	}

	void OnTriggerExit(Collider other) {
		cube.SetActive (false);
		canInteract = false;
	}

	void FixedUpdate() {
		if (Input.GetKey ("e") && canInteract && !alreadyVisited) {
			alreadyVisited = true;
			QuestionPanel.instance.setQuestion(LevelController.instance.level.questions[ForestMisteryController.instance.answeredQuestions]);
			taskCompleted();
		}
	}

	void taskCompleted() {
		cube.SetActive(false);
		anim.Play (animation);
	}
}
