using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScore : MonoBehaviour {
	public float timeLeft = 120; //countdown
	public int player_score = 0;
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0.1f) {
			SceneManager.LoadScene("world1_1");

		}
	}
	void OnTriggerEnter2D (Collider2D trig) {
		CountScore();
		Debug.Log("player Score: " + (player_score));
	}

	void CountScore() {
		player_score += (int)timeLeft *100;
	}
}
