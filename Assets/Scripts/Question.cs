using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question {
	string title;
	string question;
	List<string> options = new List<string>();
	int answer;
}
