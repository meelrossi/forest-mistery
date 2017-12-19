using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanel : MonoBehaviour {

	public static StoryPanel instance = null;
	public GameObject step1;
	public GameObject step2;
	public GameObject step3;

	int currentStep = 1;

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

	public void showStory()
	{
		gameObject.SetActive(true);
		currentStep = 1;
		step1.SetActive(true);
		step2.SetActive(false);
		step3.SetActive(false);
	}

	public void onNext()
	{
		if (currentStep == 1)
		{
			currentStep += 1;
			step1.SetActive(false);
			step2.SetActive(true);
		}
		else if (currentStep == 2)
		{
			currentStep += 1;
			step2.SetActive(false);
			step3.SetActive(true);

		}
		else {
			gameObject.SetActive(false);
		}
	}
}
