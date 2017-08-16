using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	public float speed;

	void Start ()
	{
		speed = 5;
	}
	
	void Update ()
	{
		if (transform.localPosition.x < -7f)
			GameObject.Destroy (this.gameObject);
		transform.Translate (Vector3.left * Time.deltaTime * speed);
	}

}
