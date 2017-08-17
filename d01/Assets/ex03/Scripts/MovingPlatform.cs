using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public float speed;
	Vector3 dir;

	void Start () {
		speed = 3f;
		dir = Vector3.left;
	}
	
	void Update () {
		if (transform.position.x < -18f)
			dir = Vector3.right;
		if (transform.position.x > 4f)
			dir = Vector3.left;
		transform.Translate (dir * Time.deltaTime * speed);
	}
		
}
