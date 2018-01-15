using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour {

	public Button back;

	// Use this for initialization
	void Start () {
		back.onClick.AddListener (() => {
			SceneManager.LoadScene("MainMenu");
		});
	}
}
