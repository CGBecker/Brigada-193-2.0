using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class videoCS : MonoBehaviour {


    private float timer;

    void Start()
    {
		SaveRanking.LoadGame ();
		if (global::SaveRanking.SomOn == 1) {
			Handheld.PlayFullScreenMovie("CutsceneSemSom.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		}
		if (global::SaveRanking.SomOn == 0) {
			Handheld.PlayFullScreenMovie("Cutscene.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		}
        
    }

    
    void Update () {

        timer += Time.deltaTime;

        if(timer >= 0.5F)
        {
            SceneManager.LoadScene("Menu");

        }

	}
}
