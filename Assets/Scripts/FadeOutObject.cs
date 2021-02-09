using UnityEngine;
using System.Collections;

public class FadeOutObject : MonoBehaviour {

	public float fadeOutTime = 0.3F;
	private float timer = 0;
	private bool startFading = false;
	public Material[] mats;
	public GameObject owner;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P) && !startFading) {
			startFading = true;
			mats = GetComponent<Renderer>().materials;
			timer = 0;
		}

		if (startFading) {
			timer += Time.deltaTime;
			if (timer >= fadeOutTime) {
				timer = 0;
				for (int i = 0; i < mats.Length; i++) {
					Color c = mats[i].color;
					c.a -= 0.1F;
					if (c.a <= 0) c.a = 0;
					mats[i].color = c;
				}
				if (mats[0].color.a == 0) {
					startFading = false;
					owner.SetActive(false);

					// Reload
				}
			}
		}

	}
}
