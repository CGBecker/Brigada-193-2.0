using UnityEngine;
using System.Collections;

public class PlacaFiretruck : MonoBehaviour {

	public GameObject placa;
	public GameObject placa2;
	public GameObject placa3;

	public Wayfiretruck WaypointFireTruck;

	public Wayfiretruck FireTruck;

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
		WaypointFireTruck.way1 = true;
		FireTruck.firetruck.SetActive (true);
	}
}
