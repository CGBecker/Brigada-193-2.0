using UnityEngine;
using System.Collections;

public class LeaveOpcoes : MonoBehaviour {

	public Animator Camera;
	public Animator Seta;

	public void hitByRay(){

		Camera.SetBool ("IsOpcoesOn", false);

	}

	public void triggeredByRay(){

		Seta.SetBool ("OverIt", true);
	}
}
