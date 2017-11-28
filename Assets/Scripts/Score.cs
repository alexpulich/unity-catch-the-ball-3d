using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;

	private int score;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	}

	void UpdateScore () {
		scoreText.text = "Score:\n" + score;	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Food")) {
			Destroy (other.gameObject);
			score++;
			UpdateScore ();
		}

	}
}
