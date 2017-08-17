using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript_ex00 : MonoBehaviour {

	GameObject curr;
	public float speed;

	void Start () {
		curr = GameObject.Find ("blue");
		speed = 3f;
	}
	
	void Update () {
		if (Input.GetKey ("1"))
			curr = GameObject.Find ("blue");
		if (Input.GetKey ("2"))
			curr = GameObject.Find ("red");
		if (Input.GetKey ("3"))
			curr = GameObject.Find ("yellow");
		Camera.main.GetComponent<MoveToPlayer> ().setPlayer (curr);
		if (Input.GetKey ("a"))
			curr.transform.Translate (Vector3.left * Time.deltaTime * speed);
		if (Input.GetKey ("d"))
			curr.transform.Translate (Vector3.right * Time.deltaTime * speed);
		if (Input.GetKey ("space"))
			curr.transform.Translate (Vector3.up * Time.deltaTime * speed);
		if (Input.GetKey ("r"))
			SceneManager.LoadScene ("ex00");
	}
}
