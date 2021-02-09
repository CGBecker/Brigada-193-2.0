using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StarGameMenu : MonoBehaviour {


	public AudioSource Selecao;

	public void hitByRay (){

		SceneManager.LoadScene (2);

		Selecao.Play ();


	}


}
