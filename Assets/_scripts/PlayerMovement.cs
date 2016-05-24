using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float minX, minY, maxX, maxY;

	Rigidbody playerRigidbody;

	void Awake(){

		playerRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate(){

		playerRigidbody.position = new Vector3(
			Mathf.Clamp(playerRigidbody.position.x, minX, maxX),
			Mathf.Clamp(playerRigidbody.position.y, minY,maxY),
			0.0f
		);

		playerRigidbody.rotation = Quaternion.identity; //Quaternion.Euler(0.0f, 0.0f, 0.0f)
	}
}
