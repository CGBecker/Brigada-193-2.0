using UnityEngine;
using System.Collections;

public class Opcoes : MonoBehaviour {


	public Animator Camera;

	public GameObject Back;
	private bool IsOn = false;
	private float timer;

	void Update(){

		if (IsOn == true) {
			timer += Time.deltaTime;
		
		}
	
		if (timer >= 1.2F) {
			Back.SetActive (true);
			IsOn = false;
			timer = 0;
		
		}
	}

	public void hitByRay(){

		Camera.SetBool ("IsOpcoesOn", true);
		IsOn = true;
	}

	public void BackButton(){

		Camera.SetBool ("IsOpcoesOn", false);
		Back.SetActive (false);
	}
}
