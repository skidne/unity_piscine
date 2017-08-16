using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject[] keys;
	public float period = 2f;
	public float next = 0f;

	void Start () {
	}
	
	void Update ()
	{
		if (Time.time > next)
		{
			next += period;
			switch (Random.Range (0, 3))
			{
			case 0:
				GameObject.Instantiate (keys [0], new Vector3 (-2f, 2.5f, 0f), Quaternion.identity);
				break;
			case 1:
				GameObject.Instantiate (keys [1], new Vector3 (0f, 2.5f, 0f), Quaternion.identity);
				break;
			case 2:
				GameObject.Instantiate (keys [2], new Vector3 (2f, 2.5f, 0f), Quaternion.identity);
				break;
			}
		}
	}
}
