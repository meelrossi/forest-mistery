using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	public GameObject ball;
	Vector3 offset;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	void Start () {
		offset = transform.position - ball.transform.position;
	}

	void LateUpdate () {

		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");


		Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

		transform.position = ball.transform.position - (rotation * offset);
		transform.LookAt(ball.transform);
	}
		
}
