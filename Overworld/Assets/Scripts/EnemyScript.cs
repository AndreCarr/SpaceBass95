using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float speed;

	void FixedUpdate()
	{

		
	}

	void OnTriggerStay2D(Collider2D other) {
		GameObject player = other.gameObject;
		if (player.tag == "Player") {
			float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
			//print (player.transform.position.y);
			transform.eulerAngles = new Vector3 (0, 0, z);
			
			rigidbody2D.AddForce (gameObject.transform.up * speed);
				}
		}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
