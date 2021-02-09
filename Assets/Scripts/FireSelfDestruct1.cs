using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FireSelfDestruct1 : MonoBehaviour {

	public GameObject fumaca;

	public LevelController1 LevelControler1;

	public void Start(){
	
		fumaca.SetActive (false);

		LevelControler1 = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<LevelController1>();
	}



	public void OnTriggerStay(Collider hit){



		if (hit.gameObject.tag == "AirplaneWater") {
		


			fumaca.SetActive (true);
			fumaca.GetComponent<Rigidbody>().velocity = transform.up * 1F;
			Destroy(fumaca,1F);

			LevelControler1.TakeFromList (this.gameObject);

			GameObject.Destroy (gameObject);
		
		}

		if (hit.gameObject.tag == "agua") {

			fumaca.SetActive (true);
			fumaca.GetComponent<Rigidbody>().velocity = transform.up * 1F;
			Destroy(fumaca,1F);

			LevelControler1.TakeFromList (this.gameObject);

			GameObject.Destroy (gameObject);
		}
	
	
	}
}
