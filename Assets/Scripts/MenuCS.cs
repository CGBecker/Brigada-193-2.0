using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCS : MonoBehaviour {



	void Awake () {
		Time.timeScale = 1F;
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray,out hit, 200.0f)) {
				//print ("There is something in front of the object!");

				hit.transform.SendMessage ("hitByRay");
			}
		}
	}


	public void BackToMenu(){
		

		SceneManager.LoadScene (2);
	
	}

	public void BackToMainMenu(){

		SceneManager.LoadScene (1);
	
	}




}