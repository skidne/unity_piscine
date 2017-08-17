using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public GameObject teleport;

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		col.transform.position = teleport.transform.position;
	}

}
