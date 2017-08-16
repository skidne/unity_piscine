using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Club : MonoBehaviour
{
	public Ball ball;
	public Vector3 start;
	public float speed;
	public bool turn;
	public int score;

	void Start()
	{
		start = transform.localPosition;
		speed = 0;
		turn = true;
		score = -15;
	}

	void Update ()
	{
		if (Input.GetKey ("space"))
		{
			transform.Translate (Vector3.down * Time.deltaTime);
			speed += 0.5f;
		}
		if (Input.GetKeyUp ("space"))
		{
			transform.localPosition = start;
			ball.speed = speed;
			speed = 0;
			turn = true;
		}
		if ((ball.speed < 7 && ball.transform.localPosition.y > 3 && ball.transform.localPosition.y < 3.6)
			|| score > -1)
		{
			if (score > -1)
				Debug.Log ("You lost!");
			else
				Debug.Log ("Good Job!");
			SceneManager.LoadScene ("ex02");
		}
		if (ball.speed == 0 && turn)
		{
			transform.localPosition = new Vector3(start.x, ball.transform.localPosition.y + 0.3f, start.z);
			score += 5;
			Debug.Log ("Score: " + score);
			turn = false;
		}
	}
}
