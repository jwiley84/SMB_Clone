using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {
	public int enemySpeed;
	public int xMoveDirection = 1;
//delete void start for now
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2(xMoveDirection, 0));
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * enemySpeed;
		if (hit.distance < 0.7f) {
			Flip();
		}

	}
	void Flip () {
		xMoveDirection *= -1;
	}
}
