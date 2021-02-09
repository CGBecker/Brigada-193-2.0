using UnityEngine;
using System.Collections;

public class Toco2 : MonoBehaviour {

	public bool vivo2 = true;
	public LevelController1 levelcontroller1;

	void Start () {
	
		levelcontroller1 = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<LevelController1> ();

	}

	public void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "chainsaw") {
			vivo2 = false;
			//gameObject.SetActive (false);
			StartCoroutine ("DeactivateObject", gameObject);

		}

		if (hit.gameObject.tag == "firetruck") {
			hit.gameObject.GetComponent<Wayfiretruck> ().TocoHit ();
		}
	}

	public IEnumerator DeactivateObject(GameObject go) {
		yield return new WaitForSeconds (2);
		//go.SetActive (false);
		levelcontroller1.TakeFromList3(go);
		GameObject.Destroy(go.gameObject);
	}
}