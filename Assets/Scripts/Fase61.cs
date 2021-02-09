using UnityEngine;
using System.Collections;

public class Fase61 : MonoBehaviour {

	public Botoes b1,b2,b3;
	public Toco2 tora1, tora2;
	public Coelho coelho1,coelho2,coelho3;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(coelho1.vivo == false && coelho2.vivo == false && coelho3.vivo == false){
			b1.b1.interactable = false;
		}


		if (tora1.vivo2 == false && tora2.vivo2 == false) {
			b2.b2.interactable = false;
		}

		if(ScoreManager.score < 20){
			b3.b3.interactable = false;
		}
	}
}
