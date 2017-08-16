using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public float breath;

	void Start ()
	{
		this.breath = 10f;
	}

	void Update ()
	{
		if (Input.GetKeyDown ("space") && this.breath > 0)
		{
			transform.localScale += new Vector3 (0.2f, 0.2f, 0);
			this.breath -= 3f;
		}
		if (transform.localScale.x > 7f || Time.unscaledTime > 20f)
		{
			GameObject.Destroy(this.gameObject);
			Debug.Log ("Balloon life time: " + Mathf.RoundToInt(Time.unscaledTime) + "s");
		}
		if (transform.localScale.x > 1f)
		{
			transform.localScale -= new Vector3 (0.01f, 0.01f, 0);
			if (this.breath < 10)
				this.breath += 0.3f;
		}
	}
}
