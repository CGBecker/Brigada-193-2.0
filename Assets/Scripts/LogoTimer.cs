using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoTimer : MonoBehaviour {

	public float timer;

	void Update () {
	
		timer += Time.deltaTime;

		if (timer >= 6F) {
			SceneManager.LoadScene ("Cutscene");
		
		}


	}
}
