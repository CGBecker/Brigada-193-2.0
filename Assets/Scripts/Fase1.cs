using UnityEngine;
using System.Collections;

public class Fase1 : MonoBehaviour {

	public Botoes b1, b2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		b1.b1.interactable = false;
		b2.b2.interactable = false;
	}
}
