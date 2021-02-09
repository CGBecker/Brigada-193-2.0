using UnityEngine;
using System.Collections;

public class DebugMenu : MonoBehaviour {

	public Animator Engrenagem1;
	public Animator Engrenagem2;
	public GameObject CreditsLight;
	public Animator Seta;
	public Animator ExitAnim;

	public GameObject RedLight;
	public GameObject BoxAnim;

	public void hitByRay(){
	}

	public void triggeredByRay(){
		Engrenagem1.SetBool ("IsOn", false);
		Engrenagem2.SetBool ("IsOn", false);
		CreditsLight.SetActive (false);
		Seta.SetBool ("OverIt", false);
		ExitAnim.SetBool ("OverIt", false);

		RedLight.SetActive (false);
		BoxAnim.SetActive(false);
	}
}
