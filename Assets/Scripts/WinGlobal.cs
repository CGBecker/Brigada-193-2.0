using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WinGlobal : MonoBehaviour {

	public bool vitoria = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay(Collider hit){

		if (hit.gameObject.tag == "fireman") {
			vitoria = false;
		}
	}
}
