using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToLevel2 : MonoBehaviour {


	public AudioSource Selecao;

	public void hitByRay (){

		Selecao.Play ();
		SceneManager.LoadScene (34);
	
	}
}
