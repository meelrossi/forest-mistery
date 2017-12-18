using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {
	public string title;
	public string question;
	public List<string> options;
	public int answer;

	public Question(string t, string q, List<string> op, int ans)
	{
		title = t;
		question = q;
		options = op;
		answer = ans;
	}
}
