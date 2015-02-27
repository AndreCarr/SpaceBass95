using UnityEngine;
using System.Collections;

public class Collide_With_Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other) {
		//This is where the overworld will transition into the battle scene if the enemy comes in contact with the player
		print (other.gameObject.tag);//Debug
		if (other.gameObject.tag == "Initiate Battle") {
			Debug.Log ("Start battle scene");
				}
			

	}
}
