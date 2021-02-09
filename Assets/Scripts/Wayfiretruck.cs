using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wayfiretruck: MonoBehaviour {


	public Transform[] waypoint;        // The amount of Waypoint you want
	public float patrolSpeed = 3f;       // The walking speed between Waypoints
	public bool  loop = true;       // Do you want to keep repeating the Waypoints
	public float dampingLook= 6.0f;          // How slowly to turn
	public float pauseDuration = 0;   // How long to pause at a Waypoint

	private float curTime;
	private int currentWaypoint = 0;
	private CharacterController character;

	public GameObject firetruck;
	public GameObject placa1;
	public GameObject placa2;
	public GameObject placa3;
	public Transform respawn;

	public float temp = 0;

	public bool topa = true;
	public bool way1 = false;

	public AudioSource FireTruckSound;
	private bool MadeSound;

	public Botoes botao, cdb3, cd;

	void  Start (){

		character = GetComponent<CharacterController>();
		firetruck.SetActive (false);
		placa1.SetActive (false);
		placa2.SetActive (false);
		placa3.SetActive (false);
		cdb3.cdb3.fillAmount = 0;

	}

	void  Update (){


		if (currentWaypoint < waypoint.Length) {
			if (way1){
				if (topa) {
					patrol ();
				
				} else {
					if (loop) {
						currentWaypoint = 0;
					}
				}
			}
		}
//		if (topa == true) {
//			botao.disableAllButtons ();
//			temp += Time.deltaTime;
//		} else {
//			botao.enableAllButtons ();
//		}

	}

	void  patrol (){

		Vector3 target = waypoint[currentWaypoint].position;
		target.y = transform.position.y; // Keep waypoint at character's height
		Vector3 moveDirection = target - transform.position;

		if(moveDirection.magnitude < 0.5f){
			if (curTime == 0)
				curTime = Time.time; // Pause over the Waypoint
			if ((Time.time - curTime) >= pauseDuration){
				currentWaypoint++;
				curTime = 0;
			}
		}else{
			var rotation= Quaternion.LookRotation(target - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * dampingLook);
			character.Move(moveDirection.normalized * patrolSpeed * Time.deltaTime);
		}  

		if (MadeSound == false) {
		
			FireTruckSound.Play ();
			MadeSound = true;
		
		}
	}

	public void Click(){

		placa1.SetActive(true);
		placa2.SetActive(true);
		placa3.SetActive(true);
		firetruck.transform.position = respawn.position;
		firetruck.SetActive(false);
		topa = true;
		ScoreManager.score -= 20;
		botao.disableAllButtons ();

	}

	public void TocoHit(){
		way1 = false;
		topa = false;
		//cdb3.cdb3.fillAmount = 0;
		//firetruck.transform.position = respawn.position;
		StartCoroutine ("DeactivateObject", firetruck);
	
	}

	public void OnTriggerEnter(Collider hit){

	/*	if (hit.gameObject.tag == "toco") {
			way1 = false;
			topa = false;
			//cdb3.cdb3.fillAmount = 0;
			//firetruck.transform.position = respawn.position;
			StartCoroutine ("DeactivateObject", firetruck);

			//currentWaypoint = 0;
		}*/

		if (hit.gameObject.tag == "fogo") {

			GameObject.Destroy(hit.gameObject);

		}

		if (hit.gameObject.tag == "firetruckvolta") {
			
			firetruck.transform.position = respawn.position;
			firetruck.SetActive (false);
			currentWaypoint = 0;

		}

		//print (hit.tag.ToString ());

		/*if (hit.gameObject.tag == "fim") {
			way1 = false;
			topa = false;
			//firetruck.transform.position = respawn.position;
			StartCoroutine ("DeactivateObject", firetruck);
			//currentWaypoint = 0;

		}*/
	}

	public IEnumerator DeactivateObject(GameObject go) {
		yield return new WaitForSeconds (1);
		go.SetActive (false);
		currentWaypoint = 0;
		firetruck.transform.position = respawn.position;
		topa = true;
		botao.enableAllButtons();
		FireTruckSound.Stop ();
		MadeSound = false;

	}
		
}