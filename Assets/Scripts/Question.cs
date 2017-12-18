using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {
	public string title;
	public string question;
	public List<string> options;
	public int answer;
	public string clue;

	public Question(string t, string q, List<string> op, int ans, string c)
	{
		title = t;
		question = q;
		options = op;
		answer = ans;
		clue = c;
	}
}
