using UnityEngine;
using System.Collections;

public class SomTrigger : MonoBehaviour {


	private bool IsOn = true;
	public GameObject SomOff;


	void Start(){
		SaveRanking.LoadGame ();

		if (global::SaveRanking.SomOn == 1) {
			SomOff.SetActive (false);
			IsOn = false;
			AudioListener.volume = 0f;

		}
		if (global::SaveRanking.SomOn == 0) {
			SomOff.SetActive (true);
			IsOn = true;
			AudioListener.volume = 1f;
		}
	
	}

	public void hitByRay(){

		if (IsOn==true) {

			SomOff.SetActive (false);
			IsOn = false;
			AudioListener.volume = 0f;
			SaveRanking.SomOn = 1;
			SaveRanking.SaveGame ();
	
		} else{
			if (IsOn == false) {

				SomOff.SetActive (true);
				IsOn = true;
				AudioListener.volume = 1f;
				SaveRanking.SomOn = 0;
				SaveRanking.SaveGame ();
			}
			}
	}

	public void triggeredByRay(){}
}
