using UnityEngine;
using System.Collections;

public class Wayfireman: MonoBehaviour {


	public Transform[] waypoint;        // The amount of Waypoint you want
	public float patrolSpeed = 3f;       // The walking speed between Waypoints
	public bool  loop = true;       // Do you want to keep repeating the Waypoints
	public float dampingLook= 6.0f;          // How slowly to turn
	public float pauseDuration = 0;   // How long to pause at a Waypoint

	private float curTime;
	private int currentWaypoint = 0;
	private CharacterController character;

	public GameObject fireman;

	public Transform respawn;
	public GameObject placa1;
	public GameObject placa2;
	public GameObject placa3;

	public bool topa = true;

	public Botoes botao, cdb3;
	public float temp = 0;
	public bool way1 = false;

	public Coelho coelho1, coelho2, coelho3;
	public GameObject star;

	public Animator animator;


	void  Start (){
		
		character = GetComponent<CharacterController>();
		fireman.SetActive (false);
		placa1.SetActive (false);
		placa2.SetActive (false);
		placa3.SetActive (false);
		star.SetActive(false);

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
	}

	public void Click(){
		
		if (coelho1.vivo == true) {
			placa1.SetActive (true);
		}

		if (coelho2.vivo == true) {
			placa2.SetActive (true);
		}

		if (coelho3.vivo == true) {
			placa3.SetActive (true);
		}

		fireman.SetActive (false);
		topa = true;
		fireman.transform.position = respawn.position;
		currentWaypoint = 0;
		ScoreManager.score -= 10;
		botao.disableAllButtons ();
		if(ScoreManager.score < 10){
			botao.b1.interactable = false;
		}
	}

	public void OnTriggerEnter(Collider hit){

		//print (hit.gameObject.name.ToString ());

		if (hit.gameObject.tag == "toco") {
			way1 = false;
			topa = false;
			animator.enabled = false;
			StartCoroutine ("DeactivateObject", fireman);
		}

		if (hit.gameObject.tag == "fogo") {
			way1 = false;
			topa = false;
			animator.enabled = false;
			StartCoroutine ("DeactivateObject", fireman);
		}

		if (hit.gameObject.tag == "coelho") {
			way1 = false;
			//GameObject.Destroy(hit.gameObject);
			animator.SetBool("Cat", true);
			topa = false;
			star.SetActive(true);
			star.GetComponent<Rigidbody> ().velocity = transform.up * 1F;
			StartCoroutine ("DeactivateObject", fireman);

		}

		if (hit.gameObject.tag == "fim") {
			way1 = false;
			topa = false;
			StartCoroutine ("DeactivateObject", fireman);
		}
	}

	public IEnumerator DeactivateObject(GameObject go) {
		yield return new WaitForSeconds (3);
		animator.SetBool("Cat", false);
		go.SetActive (false);
		currentWaypoint = 0;
		fireman.transform.position = respawn.position;
		topa = true;
		botao.enableAllButtons();
		star.SetActive(false);
	}
}