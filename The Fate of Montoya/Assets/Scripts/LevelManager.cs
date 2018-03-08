using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	//Button to go to Main Game Scene
	public void StartGameBtn(string Main){
		SceneManager.LoadScene ("Main");
	}

	//Button to go to Defeat Game Scene
	public void GameoverScreen(string GameOver){
		SceneManager.LoadScene ("GameOver");
	}

	//Button to go to Victory Game Scene
	public void VictoryScreen(string Victory){
		SceneManager.LoadScene ("Victory");
	}

	//Button to go to the Main Menu (will also destroy all objects in game)
	public void MainMenuBtn(string StartMenu){
		SceneManager.LoadScene ("StartMenu");
		GameObject [] objects = GameObject.FindObjectsOfType <GameObject>();
		foreach (GameObject o in objects) {
			Destroy (o);
		}
	}
}

