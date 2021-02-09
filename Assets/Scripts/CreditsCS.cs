using UnityEngine;
using System.Collections;

public class CreditsCS : MonoBehaviour {

	public GameObject credits;

	public void hitByRay(){

		credits.SetActive (true);

	}

	public void CreditOff(){
	
		credits.SetActive (false);
	}


}
