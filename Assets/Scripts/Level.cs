using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
	public string name;
	public List<Question> questions = new List<Question>();

	public Level(string n, List<Question> qs)
	{
		name = n;
		questions = qs;
	}
}
