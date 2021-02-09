using UnityEngine;
using System.Collections;

public class PlacaFireman : MonoBehaviour {

	public GameObject placa;
	public GameObject placa2;
	public GameObject placa3;

	public Wayfireman WaypointFireMan;

	public Wayfireman FireMan;

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
		WaypointFireMan.way1 = true;
		FireMan.fireman.SetActive (true);
	}
}
