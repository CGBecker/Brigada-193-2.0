using UnityEngine;
using System.Collections;

public class Agua : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "fogo") {

			GameObject.Destroy(hit.gameObject);
		}
	}
}
