using UnityEngine;
using System.Collections;

public class SummonHelicopter : MonoBehaviour {

	public Transform Helicopter;

	public Transform WP00;
	public Transform WP01;

	public bool IsSetHelicopter = false;
	public bool IsTriggered = false;
	public bool OnCooldown = false;
	public float timerForCooldown;

	public GameObject HelicopterButtonOBJ;
	public GameObject HelicopterButtonOnCooldown;

	public AudioSource HeliSound;

    public Animator TargetHeli;
  
	private bool BugControllerHelicopter = false;


	void FixedUpdate () {
	
		if (IsSetHelicopter) {
		
			Helicopter.Translate (0, 0, 0.08F);
		
		}

		if (Input.GetMouseButtonDown (0)) {

			if(IsTriggered == true){
				BugControllerHelicopter = true;
                TargetHeli.SetBool("IsTarget", true);                

				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit, 100.0f)) {

					WP00.position = new Vector3 (hit.point.x, hit.point.y + 3F, hit.point.z - 10F);
					WP01.position = new Vector3 (hit.point.x, hit.point.y + 3F, hit.point.z);
					Helicopter.position = new Vector3 (hit.point.x, hit.point.y + 3F, hit.point.z - 10F);

					Helicopter.LookAt (WP01);

					if (IsTriggered == true) {
						HeliSound.Play ();
					
					}
					IsSetHelicopter = true;
					IsTriggered = false;


				}
			}
		}

		if (Input.GetMouseButton(0) == false && BugControllerHelicopter == true) {

            TargetHeli.SetBool("IsTarget", false);
			BugControllerHelicopter = false;
        }
	}
	void Update(){

		if (OnCooldown) {
			timerForCooldown += Time.deltaTime;
		}

		if (timerForCooldown >= 10F) {
			timerForCooldown = 0F;
			OnCooldown = false;
			HelicopterButtonOBJ.SetActive (true);
			HelicopterButtonOnCooldown.SetActive (false);

		}
	}

	public void HelicopterButton(){

		OnCooldown = true;
		IsTriggered = true;
		HelicopterButtonOBJ.SetActive (false);
		HelicopterButtonOnCooldown.SetActive (true);
		ScoreManager.score -= 30;

	}


}
