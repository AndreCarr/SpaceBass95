using UnityEngine;
using System.Collections;

public class Collide_With_Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		//This is where the overworld will transition into the battle scene if the enemy comes in contact with the player
			Debug.Log ("Start battle scene");

	}
}
