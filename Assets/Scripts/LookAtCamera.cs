using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

	public Transform cam;

	void Update () {
		transform.LookAt (cam.position);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
	}
}
