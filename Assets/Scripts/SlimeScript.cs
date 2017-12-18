using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour {

	public GameObject notYetPanel;
	public GameObject cube;

	bool canInteract = false;

	void Start () {
		cube.SetActive(false);
		notYetPanel.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("boy"))
		{
			cube.SetActive(true);
			canInteract = true;
		}


	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("boy"))
		{
			cube.SetActive(false);
			notYetPanel.SetActive(false);
			canInteract = false;
		}
	}

	void FixedUpdate()
	{
		if (Input.GetKey("e") && canInteract)
		{
			if (ForestMisteryController.instance.allQuestionsAnswered())
			{
				FinalQuestionPanel.instance.openPanel();
				cube.SetActive(false);
			}
			else {
				notYetPanel.SetActive(true);
			}

		}
	}
}
