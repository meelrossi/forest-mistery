using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour {

	public GameObject camera;
	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	private float dt;

	private float speed = 2.0f;

	private Animation anim;

	void Start () {
		dt = Time.deltaTime;
		anim = GetComponent<Animation> ();
	}
	
	void FixedUpdate () {

		float xAngle = transform.eulerAngles.x;
		float yAngle = camera.transform.eulerAngles.y;

		if (Input.GetKey ("w")) {
			transform.eulerAngles = new Vector3 (xAngle, yAngle, 0.0f);
			transform.Translate (Vector3.forward * speed * dt);
			anim.Play ("Walk");
		}

		if (Input.GetKey ("a")) {
			transform.eulerAngles = new Vector3 (xAngle, yAngle - 90.0f, 0);
			transform.Translate (Vector3.forward * speed * dt);
			anim.Play ("Walk");
		}

		if (Input.GetKey ("d")) {
			transform.eulerAngles = new Vector3 (xAngle, yAngle + 90.0f, 0);
			transform.Translate (Vector3.forward * speed * dt);
			anim.Play ("Walk");
		}

		if (Input.GetKey ("s")) {
			transform.eulerAngles = new Vector3 (xAngle, yAngle + 180.0f, 0);
			transform.Translate (Vector3.forward * speed * dt);
			anim.Play ("Walk");
		} 
		if (!anim.isPlaying) {
			anim.Play ("Wait");
		}
	}
}
