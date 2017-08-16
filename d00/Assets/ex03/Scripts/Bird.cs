using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {

	public GameObject pipe;
	public float speed;
	public float score;
	public bool move;
	public float period;
	public float next;
	public float kek;

	void Start () {
		speed = 0;
		score = 0;
		move = false;
		next = 0.5f;
		period = 2f;
		kek = 0;
	}
	
	void Update ()
	{
		if (kek > next && move)
		{
			GameObject.Instantiate (this.pipe, new Vector3(7f, 2.5f, 0f), Quaternion.identity);
			next += period;
		}
		kek += 0.03f;
		foreach (GameObject pip in GameObject.FindGameObjectsWithTag("pipe"))
		{
			if (pip.transform.localPosition.x > -1.5f && pip.transform.localPosition.x < 1.5f
			    && (transform.localPosition.y > 3.71f || transform.localPosition.y < 0.9f))
				this.die ();
			else if (pip.transform.localPosition.x > -0.05f && pip.transform.localPosition.x < 0.05f
			         && (transform.localPosition.y <= 3.71f || transform.localPosition.y >= 0.9f))
				score += 2.5f;
		}
		if (transform.localPosition.y < -0.5)
			this.die ();
		if (speed <= 0 && move)
		{
			transform.rotation = Quaternion.Euler(0, 0, -20f);
			transform.Translate (new Vector3(0f, -1f, 0f) * Time.deltaTime * 7, Space.World);
		}
		if (Input.GetKeyDown ("space"))
		{
			transform.rotation = Quaternion.Euler(0f, 0f, 20f);
			speed = 7;
			move = true;
		}
		if (speed > 0)
		{
			transform.Translate (new Vector3(0f, 1f, 0f) * speed * Time.deltaTime, Space.World);
			speed -= 0.3f;
		}
	}

	public void die()
	{
		Debug.Log ("Score: " + score + "\nTime: " + Mathf.RoundToInt(Time.unscaledTime) + "s");
		SceneManager.LoadScene ("ex03");
	}

}
