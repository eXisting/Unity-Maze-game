using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class LevelCanvasSelector : MonoBehaviour {

	public Button easy;
	public Button medium;
	public Button hard;
	public Button back;

	// Use this for initialization
	void Start () {
		easy.onClick.AddListener (() => {
			SceneManager.LoadScene ("Sandbox");
		});

		medium.onClick.AddListener (() => {
			SceneManager.LoadScene ("MediumMaze");
		});

		hard.onClick.AddListener (() => {
			SceneManager.LoadScene ("HardMode");
		});

		back.onClick.AddListener (() => {
			SceneManager.LoadScene("MainMenu");
		});
	}
}
