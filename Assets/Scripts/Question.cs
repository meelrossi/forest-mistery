using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question {
	public string title;
	public string question;
	public List<string> options = new List<string>();
	public int answer;
}
