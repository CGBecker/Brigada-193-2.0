using UnityEngine;
using System.Collections;

public class ProximoMapa2 : MonoBehaviour {


	public Animator animatorDaCamera;



	public void hitByRay(){

		animatorDaCamera.SetInteger ("World", 3);
	
	}


}
