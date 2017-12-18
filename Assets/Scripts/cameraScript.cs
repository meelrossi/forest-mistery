using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	public GameObject ball;
	Vector3 offset;

	private float yaw = -40.0f;
	private float pitch = -40.0f;

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	bool cameraInTerrain = false;

	void Start () {
		offset = transform.position - ball.transform.position;
	}

	void LateUpdate () {

		yaw += speedH * Input.GetAxis("Mouse X");
		if (getDistanceToTerrain () > 1.0f) {
			pitch -= speedV * Input.GetAxis ("Mouse Y");
		} else if (Input.GetAxis ("Mouse Y") > 0.0f) {
			pitch -= speedV * Input.GetAxis ("Mouse Y");
		}

		Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

		transform.position = ball.transform.position - (rotation * offset);
		transform.LookAt(ball.transform);
	}

	private float getDistanceToTerrain() {
		RaycastHit hit;
		Physics.Raycast (transform.position, -Vector3.up, out hit);
		if (hit.collider != null && hit.collider.GetType () == typeof(TerrainCollider)) {
			return hit.distance;
		} else {
			return 10f;
		}
	}
}
