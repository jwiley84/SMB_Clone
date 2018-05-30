﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMove : MonoBehaviour {
	public int playerSpeed = 1;
	private bool facingLeft = false;
	public int playerJumpPower = 250;
	private float moveX;
	public bool isGrounded;


	//Use this for initialization
	// void Start () {
// 
	// }
	//Update is called once per frame
	void Update () {
		PlayerMove();
	}
	void PlayerMove() {
		//controlls
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump") && isGrounded == true){
			Jump();
		}

		//animation

		//player diretion
		if (moveX < 0.0f && facingLeft == false) {
			FlipPlayer();
		}
		else if (moveX > 0.0f && facingLeft == true) {
			FlipPlayer();
		}

		//physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump() {
		//jumping code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
		isGrounded = false;
	}

	void FlipPlayer(){
		facingLeft = !facingLeft;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1; //ths flips bro
		transform.localScale = localScale;
	}

	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log("Player is smushed against " + col.gameObject.tag);
		if (col.gameObject.tag == "groundBrick") {
			isGrounded = true;
		}
	}
}  