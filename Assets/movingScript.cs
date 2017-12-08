using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {

		if (Input.GetKey ("up")) {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * 15f);
		}

		if (Input.GetKey ("left")) {
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 15f);
		}

		if (Input.GetKey ("right")) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 15f);
		}

		if (Input.GetKey ("down")) {
			GetComponent<Rigidbody> ().AddForce (Vector3.back * 15f);
		} 
	}
}
