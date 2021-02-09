using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {

	public Transform target;
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.LookAt (target);
	
	}
}
