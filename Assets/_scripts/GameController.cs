using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

	public Text scoreText;

	[SerializeField]
	Canvas gameOverCanvas;

	int score;

	GameObject[] spawner;

	AudioSource bgMusic;

	void Awake(){

		bgMusic = GetComponent<AudioSource>();
	}

	void Start(){

		gameOverCanvas.enabled = false;
	}

	public void AddScore(int points){

		score+= points;
		scoreText.text = score.ToString();
	}

	public void GameOver(){

		gameOverCanvas.enabled = true;
		bgMusic.Stop();
		spawner = GameObject.FindGameObjectsWithTag("Spawner");
		foreach (GameObject spawn in spawner){
			spawn.SetActive(false);
		}
	}

	public void Restart(){
		SceneManager.LoadScene(0);
	}
}
