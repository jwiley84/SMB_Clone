﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

	private GameObject player;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		//GO tag your player! select mario, change from 'untagged' to player 
    }


	// Update is called once per frame
	void LateUpdate () {//this is the version of do-while
		float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
		//this clamps the camera to the player
		float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
		gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
	}
}