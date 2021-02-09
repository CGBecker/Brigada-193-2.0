using UnityEngine;
using System.Collections;

public class Nuvem : MonoBehaviour {

	public Transform respawn;
	public float temp = 0;
	public bool vai = true;

	void Start () {
	

	}

	void Update () {
	
		if(vai == false){
			temp += Time.deltaTime;

		}

	}

	public void OnTriggerEnter(Collider hit){

		if(hit.gameObject.tag == "nuvem"){

			//gameObject.SetActive(false);
			gameObject.GetComponent<Animator>().enabled = false;
			vai = false;
		}

			if(temp >= 5){
				transform.position = respawn.position;
				temp = 0;
				vai = true;
				gameObject.GetComponent<Animator>().Play(1);
			}
	}
}
