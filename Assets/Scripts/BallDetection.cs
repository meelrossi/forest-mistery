using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

	public GameObject cube;
	public string animation;
	bool canInteract = false;
	 

	private Animation anim;

	void Start () {
		cube.SetActive (false);
		anim = GetComponent<Animation> ();
	}

	void OnTriggerEnter(Collider other) {
		cube.SetActive (true);
		canInteract = true;
	}

	void OnTriggerExit(Collider other) {
		cube.SetActive (false);
		canInteract = false;
	}

	void FixedUpdate() {
		if (Input.GetKey ("e") && canInteract) {
			Debug.Log("dasdad");
			QuestionPanel.instance.setQuestion(LevelController.instance.level.questions[0]);
			taskCompleted();
		}
	}

	void taskCompleted() {
		anim.Play (animation);
		cube.SetActive (false);
	}
}
