using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Waychainsaw: MonoBehaviour {


	public Transform[] waypoint;        // The amount of Waypoint you want
	public float patrolSpeed = 3f;       // The walking speed between Waypoints
	public bool  loop = true;       // Do you want to keep repeating the Waypoints
	public float dampingLook= 6.0f;          // How slowly to turn
	public float pauseDuration = 0;   // How long to pause at a Waypoint

	private float curTime;
	private int currentWaypoint = 0;
	private CharacterController character;

	public GameObject chainsaw;
	public GameObject placa1;
	public GameObject placa2;
	public GameObject placa3;
	public GameObject toco;

	public Transform respawn;

	public bool topa = true;
	public bool way1 = false;

	public Botoes botao, cdb3;
	public float temp = 0;

	public Toco2 tora1, tora2, tora3;

	public Animator animator;



	void  Start (){
		character = GetComponent<CharacterController>();
		chainsaw.SetActive (false);
		placa1.SetActive (false);
		placa2.SetActive (false);
		placa3.SetActive (false);
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

//		if (tora3.vivo2 == false) {
//			botao.chainsawOff ();
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
	}

	public void Click(){

		ScoreManager.score -= 10;
		chainsaw.transform.position = respawn.position;
		chainsaw.SetActive(false);
		currentWaypoint = 0;
		topa = true;
		botao.disableAllButtons ();

		if (tora1.vivo2 == true) {
			placa1.SetActive (true);
		}


        if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            if (tora2.vivo2 == true)
            {
                placa2.SetActive(true);
            }
                        
        }

        if(SceneManager.GetActiveScene().buildIndex >= 16)
        {
            if (tora2.vivo2 == true)
            {
                placa2.SetActive(true);
            }

            if (tora3.vivo2 == true)
            {
                placa3.SetActive(true);
            }

        }
	}

	public void OnTriggerEnter(Collider hit){

		if (hit.gameObject.tag == "toco") {

			way1 = false;
			topa = false;
			animator.SetBool("Cut", true);
			StartCoroutine ("DeactivateObject", chainsaw);
		}

		if (hit.gameObject.tag == "fogo") {
			way1 = false;
			topa = false;
			animator.enabled = false;
			StartCoroutine ("DeactivateObject", chainsaw);
		}

		if (hit.gameObject.tag == "fim") {
			way1 = false;
			topa = false;
			StartCoroutine ("DeactivateObject", chainsaw);
		}
	}

	public IEnumerator DeactivateObject(GameObject go) {
		yield return new WaitForSeconds (2);
		animator.SetBool("Cut", false);
		go.SetActive (false);
		currentWaypoint = 0;
		chainsaw.transform.position = respawn.position;
		topa = true;
		botao.enableAllButtons ();
//		if (tora1.vivo2 == true) {
//			botao.enableAllButtons ();
//		} else {
//			botao.enableAllButtons ();
//			botao.chainsawOff ();
//		}
	}
}