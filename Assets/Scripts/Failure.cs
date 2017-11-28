using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Failure : MonoBehaviour {

	public Text failsText;

	private int fails;

	void Start () {
		fails = 0;
		UpdateFails ();
	}

	void UpdateFails () {
		failsText.text = "Fails:\n" + fails;	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Food")) {
			fails++;
			UpdateFails ();
		}
	}

	public int getFails() {
		return fails;
	}
}
