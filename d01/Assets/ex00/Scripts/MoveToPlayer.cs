using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	void Start () {
		offset = new Vector3 (0f, 0f, -10f);
		player = GameObject.Find ("blue");
	}
	
	void Update () {
		transform.position = player.transform.position + offset;
	}

	public void setPlayer(GameObject player)
	{
		this.player = player;
	}

}
