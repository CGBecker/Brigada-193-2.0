using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToLevel8 : MonoBehaviour {



	public AudioSource Selecao;

	public void hitByRay (){

		Selecao.Play ();
		SceneManager.LoadSceneAsync ("8");
	
	}
}
