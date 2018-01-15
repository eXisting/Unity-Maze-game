using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class QuitInGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene ("MainMenu");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");	
		}
	}
}
