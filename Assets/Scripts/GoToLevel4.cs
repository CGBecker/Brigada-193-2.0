﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToLevel4 : MonoBehaviour {




	public AudioSource Selecao;

	public void hitByRay (){

		Selecao.Play ();
		SceneManager.LoadSceneAsync ("4");
	
	}
}
