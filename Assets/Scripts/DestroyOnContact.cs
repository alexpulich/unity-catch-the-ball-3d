using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Food"))
			Destroy (other.gameObject);
	}
}
