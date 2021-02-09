using UnityEngine;
using System.Collections;

public class PlacaFireoutro : MonoBehaviour {

	public GameObject placa;
	public GameObject placa2;
	public GameObject placa3;

	public Waychainsaw WaypointChainsaw;

	public Waychainsaw Chainsaw;

	public Botoes cdb3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hitByRay (){

		placa.SetActive(false);
		placa2.SetActive (false);
		placa3.SetActive (false);
		WaypointChainsaw.way1 = true;
		Chainsaw.chainsaw.SetActive (true);
	}
}
