using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject azul;
	public Vector3 targetPosition;
	public float spd = 2;
	public Transform respawn;

	void Start () {

		targetPosition = transform.position;
		azul.SetActive (false);
	}

	void Update(){

		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)){
				targetPosition = hit.point;
				azul.transform.position = targetPosition;
				
			}
		}
	}


	public void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "fogo") {

			GameObject.Destroy(hit.gameObject);
			azul.transform.position = respawn.position;
			azul.SetActive (false);
		}
	}

	public void Click(){
		azul.SetActive (true);
	}
}