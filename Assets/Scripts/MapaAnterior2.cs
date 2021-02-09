using UnityEngine;
using System.Collections;

public class MapaAnterior2 : MonoBehaviour {

	public Animator animatorDaCamera;

	public void hitByRay(){

		animatorDaCamera.SetInteger ("World", 2);
	
	}
}
