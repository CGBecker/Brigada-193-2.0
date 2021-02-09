using UnityEngine;
using System.Collections;

public class DropHCS : MonoBehaviour {


	public GameObject WaterDrop;
	public Transform WP01;

	public bool IsActive = false;

	void FixedUpdate(){
	
		if(IsActive == false){
			WaterDrop.transform.position = new Vector3 (WP01.position.x, WP01.position.y, WP01.position.z);
		}
	}

	public void OnTriggerEnter (Collider other){
	
		if (other.gameObject.tag == "DropH") {
		
			WaterDrop.SetActive (true);
			IsActive = true;
		
		}
	
	}
	

}
