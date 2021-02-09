using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Coelho : MonoBehaviour{

	//public Image barra;
	public GameObject vida, frito, fogo, fuma;
	public float temp;
	public  bool vivo;
	public LevelController1 levelcontroller1;

	private bool initiateFire, initiateSmoke;
	private bool destroyFire, destroySmoke;

	public void Start ()
	{

		fuma.SetActive (false);
		fogo.SetActive (false);
		frito.SetActive (false);
		temp = 0;
		vivo = true;
		initiateFire = false;
		initiateSmoke = false;
		destroyFire = false;
		destroySmoke = false;
		levelcontroller1 = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<LevelController1> ();
	}

	public void OnTriggerStay (Collider hit){
	
		if (hit.gameObject.tag == "fogo") {

//			barra.fillAmount -= 0.0009F;
//			if (barra.fillAmount <= 0.01F) {
//				GameObject.Destroy(gameObject);
//			}

			var scale = vida.transform.localScale;
			scale.x -= 0.0005F;
			if (scale.x < 0)
				scale.x = 0;
			vida.transform.localScale = scale;

			if (scale.x <= 0) {
				temp += Time.deltaTime;
				if (!initiateFire) {
					initiateFire = true;
					fogo.SetActive (true);
				}

				vivo = false;
				Troca ();
			}
		}
	}

	public void OnTriggerExit(Collider hit){

		if(hit.gameObject.tag == "fogo"){
			vida.SetActive(false);
		}
	}

	public void OnTriggerEnter (Collider hit)
	{
	
		if (hit.gameObject.tag == "fireman") {

			vivo = false;
			//gameObject.SetActive (false);
			StartCoroutine ("DeactivateObject", gameObject);
		}
	}

	public IEnumerator DeactivateObject(GameObject go) {
		yield return new WaitForSeconds (2);
		levelcontroller1.TakeFromList2 (go);
		print ("took from list");
		GameObject.Destroy (go);
	}

	public void Troca ()
	{
		
		if (temp >= 1) {
			if (!initiateSmoke) {
				initiateSmoke = true;
				fuma.SetActive (true);
			}


			//fuma.GetComponent<Rigidbody> ().velocity = transform.up * 1F;

			if (!destroyFire) {
				destroyFire = true;
				Destroy (fogo, 1F);
			}

			if (!destroySmoke) {
				destroySmoke = true;
				Destroy (fuma, 1F);
			}
				


		}

		if (temp > 2) {
			frito.SetActive (true);
			gameObject.SetActive (false);
		}
	}
}
//gameObject.SetActive(false);
//frito.SetActive(true);
			



