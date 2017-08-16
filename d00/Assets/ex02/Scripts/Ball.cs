using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed;
	public bool up;

	void Start ()
	{
		speed = -10;
		up = true;
	}
	
	void Update () 
	{
		if (speed > 0)
		{
			if (transform.localPosition.y > 3.5)
				up = false;
			if (transform.localPosition.y < -2.5)
				up = true;
			transform.Translate (goDirection() * speed * Time.deltaTime);
			speed -= 0.3f;
			if (speed < 0)
				speed = 0;
		}
	}

	Vector3 goDirection()
	{
		if (!up)
			return Vector3.down;
		return Vector3.up;
	}

}
