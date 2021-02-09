using UnityEngine;
using System.Collections;

public class Tora : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "fireman") {

			GameObject.Destroy (hit.gameObject);
		}

		if (hit.gameObject.tag == "firetruck") {

			GameObject.Destroy (hit.gameObject);
		}

	}
		
}