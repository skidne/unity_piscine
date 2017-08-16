using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	public PongBall ball;
	public static int score1;
	public static int score2;

	void Start()
	{
		speed = 15f;
		score1 = 0;
		score2 = 0;
	}

	void Update ()
	{
		if (gameObject.tag.Equals ("player1"))
		{
			if (Input.GetKey ("w") && transform.localPosition.y <= 4)
				transform.Translate (Vector3.up * Time.deltaTime * speed);
			if (Input.GetKey ("s") && transform.localPosition.y >= -4)
				transform.Translate (Vector3.down * Time.deltaTime * speed);
			if (ball.transform.localPosition.x <= -5.5f && ball.transform.localPosition.y <= transform.localPosition.y + 1f
			    && ball.transform.localPosition.y >= transform.localPosition.y - 1f)
			{
				ball.dir [0] = Vector3.right;
				ball.dir [1] = (ball.transform.localPosition.y < transform.localPosition.y) ? Vector3.down : Vector3.up;
			}
			else if (ball.transform.localPosition.x < -6f)
			{
				score2++;
				Debug.Log ("Player 1: " + score1 + " | Player 2: " + score2);
				ball.reset ();
			}
		}
		if (gameObject.tag.Equals ("player2"))
		{
			if (Input.GetKey (KeyCode.UpArrow) && transform.localPosition.y <= 4)
				transform.Translate (Vector3.up * Time.deltaTime * speed);
			if (Input.GetKey (KeyCode.DownArrow) && transform.localPosition.y >= -4)
				transform.Translate (Vector3.down * Time.deltaTime * speed);
			if (ball.transform.localPosition.x >= 5.5f && ball.transform.localPosition.y <= transform.localPosition.y + 1f
				&& ball.transform.localPosition.y >= transform.localPosition.y - 1f)
			{
				ball.dir [0] = Vector3.left;
				ball.dir [1] = (ball.transform.localPosition.y < transform.localPosition.y) ? Vector3.down : Vector3.up;
			}
			else if (ball.transform.localPosition.x > 6f)
			{
				score1++;
				Debug.Log ("Player 1: " + score1 + " | Player 2: " + score2);
				ball.reset ();
			}
		}

		if (ball.transform.localPosition.y >= 4.75f)
			ball.dir [1] = Vector3.down;
		if (ball.transform.localPosition.y <= -4.75f)
			ball.dir [1] = Vector3.up;
	}

}
