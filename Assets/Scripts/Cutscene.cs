using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class Cutscene : MonoBehaviour {

	//public MovieTexture Video = new MovieTexture();
	private AudioSource Audio;

	public float timer;

	void Awake(){ Application.targetFrameRate = 30;}
	void Start () {
		//GetComponent<RawImage> ().texture = Video as MovieTexture;
		Audio = GetComponent<AudioSource> ();
		//Audio.clip = Video.audioClip;
		//Video.Play ();
		Audio.Play ();
	}
	

	void Update () {

		timer += Time.deltaTime;

		if(timer >= 10F){SceneManager.LoadScene ("Menu");}
	
	}
}
