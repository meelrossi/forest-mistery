using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	public GameObject ball;
	Vector3 offset;
	float xAngleMax = 320.0f;
	float xAngleMin = 270.0f;

	void Start () {
		offset = transform.position - ball.transform.position;
	}

	void LateUpdate () {
		float yAngle = ball.transform.eulerAngles.y;
		float xAngle = ball.transform.eulerAngles.x;

		//xAngle = xAngle < xAngleMin ? xAngleMin : xAngle;
		//xAngle = xAngle > xAngleMax ? xAngleMax : xAngle;

		Quaternion rotation = Quaternion.Euler(xAngle, yAngle, 0);

		transform.position = ball.transform.position - (rotation * offset);
		transform.LookAt(ball.transform);
	}
		
}
