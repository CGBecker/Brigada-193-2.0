using UnityEngine;
using System.Collections;

public class Fase2 : MonoBehaviour {

	public Botoes b1,b2;
	public Toco2 tora1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		b1.b1.interactable = false;

		if (tora1.vivo2 == false) {
			b2.b2.interactable = false;
		}
	}
}
