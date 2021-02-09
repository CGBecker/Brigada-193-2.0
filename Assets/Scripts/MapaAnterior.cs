using UnityEngine;
using System.Collections;

public class MapaAnterior : MonoBehaviour {

	public Animator animatorDaCamera;

	public void hitByRay(){

		animatorDaCamera.SetInteger ("World", 1);
	
	}
}
