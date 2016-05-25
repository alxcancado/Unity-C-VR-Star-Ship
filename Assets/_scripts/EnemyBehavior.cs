using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	GameController gameController;
	Rigidbody enemyRigidbody;
	float speed = 5.0f;
	AudioSource audioSource;

	void Awake(){

		gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
		enemyRigidbody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}

	void Start(){

		// rotate around itself. the velocity will randomly change based on speed
		enemyRigidbody.angularVelocity = Random.insideUnitSphere * speed;
		// we need to spawn the asteroid towards the player
		enemyRigidbody.velocity = transform.forward * speed;

	}

	// colision
	void OnTriggerEnter(Collider other){

		if (other.tag == "Player"){

			audioSource.Play();
			// set game over
			//gameController.GameOver();
			// destroy obj, delay 0.5 so it gives the chance to play the sfx
			Destroy(gameObject, 0.5f);
			Destroy(other);

		}
	}
}
