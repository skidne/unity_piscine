using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript_ex01 : MonoBehaviour {

	GameObject curr;
	public float speed;
	bool[] done;

	void Start () {
		curr = GameObject.Find ("blue");
		speed = 1.5f;
		done = new bool[3];
	}

	void Update ()
	{
		check_end ();
		if (Input.GetKey ("1"))
		{
			curr = GameObject.Find ("blue");
			speed = 1.5f;
		}
		if (Input.GetKey ("2")) 
		{
			curr = GameObject.Find ("red");
			speed = 3f;
		}
		if (Input.GetKey ("3"))
		{
			curr = GameObject.Find ("yellow");
			speed = 5f;
		}
		Camera.main.GetComponent<MoveToPlayer> ().setPlayer (curr);
		if (Input.GetKey ("a"))
			curr.transform.Translate (Vector3.left * Time.deltaTime * speed);
		if (Input.GetKey ("d"))
			curr.transform.Translate (Vector3.right * Time.deltaTime * speed);
		if (Input.GetKey ("space"))
			curr.transform.Translate (Vector3.up * Time.deltaTime * speed);
		if (Input.GetKey ("r"))
			SceneManager.LoadScene ("ex01");
	}

	void check_end()
	{
		if (curr.name == "blue" && curr.transform.position.x > 19.5f && curr.transform.position.x < 19.7f
		    && curr.transform.position.y > 4.8f && curr.transform.position.y < 5f)
			done [0] = true;
		if (curr.name == "red" && curr.transform.position.x > 19.5f  && curr.transform.position.x < 19.7f
			&& curr.transform.position.y > 6f && curr.transform.position.y < 6.3f)
			done[1] = true;
		if (curr.name == "yellow" && curr.transform.position.x > 19.5f && curr.transform.position.x < 19.7f
		    && curr.transform.position.y > 7.5f && curr.transform.position.y < 7.8f)
			done [2] = true;
		if (done [0] && done [1] && done [2]) {
			Debug.Log ("You passed the level! Next level.");
			SceneManager.LoadScene ("ex02");
		}
	}

}
