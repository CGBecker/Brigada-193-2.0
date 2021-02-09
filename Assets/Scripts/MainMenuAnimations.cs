using UnityEngine;
using System.Collections;

public class MainMenuAnimations : MonoBehaviour {





	void FixedUpdate () {


		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit, 100.0f)) {

			hit.transform.SendMessage ("triggeredByRay");
		}

	


			
	}
}
