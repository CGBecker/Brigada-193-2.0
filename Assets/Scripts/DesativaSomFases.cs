using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesativaSomFases : MonoBehaviour {


	void Start () {
		SaveRanking.LoadGame ();
		if (global::SaveRanking.SomOn == 1) {
			AudioListener.volume = 0f;
		}
		if (global::SaveRanking.SomOn == 0) {
			AudioListener.volume = 1f;
		}
	}

}
