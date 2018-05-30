using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//falls down hole
		if (gameObject.transform.position.y < -7) { //taking parts out to slim down code
			Die();//removed 'start corouting'
		}//took out excessive lines
	}
	void Die () {//changed this to a method so it can be called without a wait
		SceneManager.LoadScene ("world1_1");
	}
}