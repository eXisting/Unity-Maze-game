using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class MainButtons : MonoBehaviour {

	public Button exit;
	public Button play;

	public void Start()
	{
		play.onClick.AddListener (() => {
			SceneManager.LoadScene ("LevelChoose");
		});
		exit.onClick.AddListener (() => {
		});
		exit.onClick.AddListener (() => {
			Application.Quit();
		});
	}
}
