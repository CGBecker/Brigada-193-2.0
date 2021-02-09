using UnityEngine;
using System.Collections;

public class SummonAirplane : MonoBehaviour {


	public Transform WP00;
	public Transform WP01;
	public Transform WP02;
	public Transform WP03;

	public Transform Airplane;
	public bool IsSetAirplane = false;
	public bool IsTriggered = false;
	public bool OnCooldown = false;
	public GameObject AirplaneButtonOBJ;
	public GameObject AirplaneButtonOnCooldown;
	public float timerForCooldown;

	public AudioSource AirplaneSound;

    public Animator Seta;

	private bool BugControllerAirplane = false;

	

	void FixedUpdate () {


		if (IsSetAirplane == true) {
		
			Airplane.Translate (0, 0, 0.08F);


		
		}


	
		if (Input.GetMouseButtonDown (0)) {

			if(IsTriggered == true){
				BugControllerAirplane = true;
                Seta.SetBool("IsSummoned", true);
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit, 100.0f)) {

					WP01.position = new Vector3 (hit.point.x, hit.point.y + 2F, hit.point.z);

				
					//print ("X=" + hit.point.x + "  Y=" + hit.point.y + "  Z=" + hit.point.z);
				}
			}
		}

		if (Input.GetMouseButton (0)) {

			if (IsTriggered == true) {
				RaycastHit hit2;
				Ray ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray2, out hit2, 100.0f)) {

					WP02.position = new Vector3 (hit2.point.x, hit2.point.y + 2F, hit2.point.z);

					WP01.LookAt (WP02);
					WP02.LookAt (WP01);
					Airplane.LookAt (WP02);

					Ray raioGuia1 = new Ray (WP01.position, WP01.forward);
					Ray raioGuia2 = new Ray (WP02.position, WP02.forward);

					WP03.position = new Vector3 (raioGuia1.GetPoint (15).x, raioGuia1.GetPoint (15).y, raioGuia1.GetPoint (15).z);
					WP00.position = new Vector3 (raioGuia2.GetPoint (15).x, raioGuia2.GetPoint (15).y, raioGuia2.GetPoint (15).z);
					Airplane.position = new Vector3 (raioGuia2.GetPoint (15).x, raioGuia2.GetPoint (15).y, raioGuia2.GetPoint (15).z);





				}
			}
		
		}

		if (Input.GetMouseButton (0) == false && BugControllerAirplane == true) {

			if (IsTriggered == true) {
                Seta.SetBool("IsSummoned", false);
				AirplaneSound.Play ();
				IsSetAirplane = true;
				Airplane.gameObject.SetActive (true);
			}

			IsTriggered = false;
			BugControllerAirplane = false;

		
		}

	}

	void Update(){

		if (OnCooldown) {
			timerForCooldown += Time.deltaTime;
		}

		if (timerForCooldown >= 10F) {
			timerForCooldown = 0F;
			OnCooldown = false;
			AirplaneButtonOBJ.SetActive (true);
			AirplaneButtonOnCooldown.SetActive (false);
		
		}
	}

	public void AirplaneButton(){

		OnCooldown = true;
		IsTriggered = true;
		AirplaneButtonOBJ.SetActive (false);
		AirplaneButtonOnCooldown.SetActive (true);
		ScoreManager.score -= 50;
	
	}
}
