using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Camera cam;

	public GameObject startBtn;
	public GameObject restartBtn;
	public GameObject gameOverText;
	public GameObject food;
	public Failure failure;
	public BucketController bucketController;

	public float XSize = 9.0f;
	public float YSize = 9.0f;


	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
	}
	
	public void StartGame() {
		StartCoroutine (Spawn());
		startBtn.SetActive (false);
		bucketController.ToggleControl (true);
	}

	IEnumerator Spawn() {
		while (failure.getFails() < 5) {
			Vector3 spawnPosition = new Vector3 (
				Random.Range(-XSize, XSize), 15.0f, Random.Range(-YSize, YSize)
			);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (food, spawnPosition, spawnRotation);
			Physics.gravity = new Vector3(0, Physics.gravity.y-0.1f, 0);
			yield return new WaitForSeconds (Random.Range (1.5f, 2.5f));
		}
		gameOverText.SetActive (true);
		restartBtn.SetActive (true);
		bucketController.ToggleControl (false);
	}
}
