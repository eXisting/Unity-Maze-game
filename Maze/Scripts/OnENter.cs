using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class OnENter : MonoBehaviour {

	void OnTriggerEnter()
	{
		SceneManager.LoadScene ("EndingScene");
	}
}
