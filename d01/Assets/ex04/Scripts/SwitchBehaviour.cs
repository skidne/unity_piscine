using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour {

	bool once = true;
	bool els = true;
	GameObject[] obj;

	void Start () {
		obj = GameObject.FindGameObjectsWithTag ("movingPlatform");
		foreach (GameObject one in obj) {
			one.GetComponent<MovingPlatform> ().enabled = false;
			one.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
	
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.name == "blue") {
			if (once) {
				Debug.Log ("Press E to switch on.");
				once = false;
			}
			if (Input.GetKey ("e"))
				foreach (GameObject one in obj) {
					one.GetComponent<MovingPlatform> ().enabled = true;
					one.GetComponent<BoxCollider2D> ().enabled = true;
				}
		} else if (els) {
			Debug.Log ("Only Thomas is able to switch this on.");
			els = false;
		}
	}

}
