using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {
	
	public void changeScene(int changer)
	{
		SceneManager.LoadScene (changer);
	}
}
