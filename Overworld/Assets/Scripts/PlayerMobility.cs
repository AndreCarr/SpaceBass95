using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

	public float speed;
	void FixedUpdate()
	{
		//var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//Quaternion rot = Quaternion.LookRotation (transform.position, Vector3.foward);

		//transform.rotation = rot;
		//transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);


		float input_vertical = Input.GetAxis ("Vertical");
		float input_horizontal = Input.GetAxis("Horizontal");

		rigidbody2D.AddForce (gameObject.transform.up * speed * input_vertical);
		rigidbody2D.AddForce (gameObject.transform.right * speed * input_horizontal);
		//rigidbody2D.add = speed*input_horizontal;
	}

	// Use this for initialization
	void Start () {
	}
}
