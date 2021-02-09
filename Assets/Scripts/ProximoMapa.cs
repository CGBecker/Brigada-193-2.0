using UnityEngine;
using System.Collections;

public class ProximoMapa : MonoBehaviour {


	public Animator animatorDaCamera;



	public void hitByRay(){

		animatorDaCamera.SetInteger ("World", 2);
	
	}


}
