using UnityEngine;
using System.Collections;

public class HeliAgua : MonoBehaviour {

	public DropHCS DropHCS;

	public void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "WaterDeactivator") {
			DropHCS.IsActive = false;
			DropHCS.WaterDrop.SetActive (false);
		
		}

	
	}

	public void FixedUpdate(){
		this.gameObject.transform.Translate (0, -0.13F, 0);
	
	}
}
