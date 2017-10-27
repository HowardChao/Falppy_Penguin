using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  			// to import this to get the scene
using UnityEngine.UI; 							// allow us to create the UI object


public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;
	public Text scoreText;

	private int score = 0;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (instance);//gameObject?
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}
	public void birdScored(){
		if (gameOver) {
			return;
		} else {
			score++;
			scoreText.text = "Score: " + score.ToString ();
		}
	}

}
