using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour {

	public Camera cam;
	public float speed = 12.0f;
	private float coordMax = 8.7f;

	private bool canControl;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
		canControl = false;
	}

	// Update is called once per physics timestep
	void FixedUpdate () {
		if (canControl) {
			if (Input.GetKey (KeyCode.A) && transform.position.x > -coordMax) {
				transform.Translate (Vector3.left * speed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.D) && transform.position.x < coordMax) {
				transform.Translate (Vector3.right * speed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.W) && transform.position.z < coordMax) {
				transform.Translate (Vector3.forward * speed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.S) && transform.position.z > -coordMax) {
				transform.Translate (Vector3.back * speed * Time.deltaTime);
			}
		}
	}

	public void ToggleControl(bool toggle) {
		canControl = toggle;
	}
}
