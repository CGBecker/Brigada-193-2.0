using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWalkTruckDeactiv : MonoBehaviour {


	public void OnTriggerEnter(Collider hit){
	
		if (hit.gameObject.tag == "agua") {
			return;
		}

		if (hit.gameObject.tag == "firetruck") {
			hit.gameObject.GetComponent<Wayfiretruck> ().TocoHit ();
		
		}
	
	
	}
}