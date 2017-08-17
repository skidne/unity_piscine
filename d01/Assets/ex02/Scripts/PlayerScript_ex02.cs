using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript_ex02 : MonoBehaviour {

	GameObject curr;
	public float speed;

	void Start () {
		curr = GameObject.Find ("blue");
		speed = 1.5f;
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
			SceneManager.LoadScene ("ex02");
	}

	void check_end()
	{
		if (curr.transform.position.x > -11f && curr.transform.position.x < -10.5f
			&& curr.transform.position.y > 5f && curr.transform.position.y < 6f)
		{
			Debug.Log ("You passed the level! Next level.");
			SceneManager.LoadScene ("ex03");
		}
	}

}
