using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public Vector3 speed;

	void Start()
	{
		this.speed = new Vector3(0f, Random.Range (0.05f, 0.2f), 0f);
	}

	void Update ()
	{
		string[] keys = { "a", "s", "d" };

		transform.localPosition -= speed;

		if (transform.localPosition.y < -4.5)
			GameObject.Destroy (this.gameObject);
		for (int i = 0; i < 3; i++)
		{
			if (gameObject.tag.Equals (keys[i]) && Input.GetKeyDown (keys[i]))
			{
				Debug.Log ("Precision: " + Precision ().ToString("F3"));
				GameObject.Destroy (this.gameObject);
			}
		}
	}

	float Precision()
	{
		float precision = 0;

		if (transform.localPosition.y <= -2 && transform.localPosition.y >= -4)
			precision = Mathf.Abs (transform.localPosition.y - 3f) * 100 / 6;
		return (precision > 100) ? 100f : precision;
	}
}
