using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

	public bool move;
	public float speed;
	public Vector3[] dir = new Vector3[2];

	void Start () {
		this.reset ();
	}
	
	void Update () {
		if (Input.anyKeyDown)
			move = true;
		if (move) {
			transform.Translate (dir[0] * Time.deltaTime * speed);
			transform.Translate (dir[1] * Time.deltaTime);
		}
	}

	public void reset()
	{
		move = false;
		transform.localPosition = new Vector3 (0f, 0f, 0f);
		speed = 5f;
		dir [0] = Vector3.right;
		dir [1] = Vector3.up;
	}
}
