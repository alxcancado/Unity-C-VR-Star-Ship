using UnityEngine;
using System.Collections;

public class RingBahavior : MonoBehaviour {

	public int points;

	GameController gameController;
	Rigidbody enemyRigidbody;
	float speed = 5.0f;
	AudioSource audioSource;

	void Awake(){

		gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		enemyRigidbody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}

	void Start(){

		// we need to spawn the asteroid towards the player
		enemyRigidbody.velocity = transform.forward * speed;

	}

	// colision
	void OnTriggerEnter(Collider other){

		if (other.tag == "Player"){

			audioSource.Play();
			gameController.AddScore(points);
			// destroy obj, delay 0.5 so it gives the chance to play the sfx
			Destroy(gameObject, 0.5f);


		}
	}
}
