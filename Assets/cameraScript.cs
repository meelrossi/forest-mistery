using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	public GameObject ball;
	Vector3 offset;

	void Start () {
		offset = transform.position - ball.transform.position;
	}

	void LateUpdate () {
		Vector3 newpos = new Vector3 (ball.transform.position.x + offset.x, ball.transform.position.y + offset.y, ball.transform.position.z + offset.z);
		transform.position = newpos;
	}
}
