using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDetection : MonoBehaviour {

	public GameObject cube;
	bool canInteract = false;

	void Start () {
		cube.SetActive (false);
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
			//show canvas.
		}
	}
}
