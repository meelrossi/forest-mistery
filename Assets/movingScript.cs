using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour {

	public GameObject camera;
	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Start () {
		
	}
	
	void FixedUpdate () {


		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

		if (Input.GetKey ("w")) {
			GetComponent<Rigidbody> ().AddForce (camera.transform.forward * 15f);
		}

		if (Input.GetKey ("a")) {
			GetComponent<Rigidbody> ().AddForce (camera.transform.right * -15f);
		}

		if (Input.GetKey ("d")) {
			GetComponent<Rigidbody> ().AddForce (camera.transform.right * 15f);
		}

		if (Input.GetKey ("s")) {
			GetComponent<Rigidbody> ().AddForce (camera.transform.forward * -15f);
		} 
	}
}
