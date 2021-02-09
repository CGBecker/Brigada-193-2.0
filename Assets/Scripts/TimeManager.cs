using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

	public  float timer; 
	public static float t;
	public float rand = 0;
	public bool ttempo = true;
	public GameObject lose1, lose2, lose3, lose4, lose5, lose6, lose7, lose8, lose9, lose10;

	public AudioSource LoseSound;

	Text text; 

	public void Start(){
		
		lose1.SetActive (false);
		lose2.SetActive (false);
		lose3.SetActive (false);
		lose4.SetActive (false);
		lose5.SetActive (false);
		lose6.SetActive (false);
		lose7.SetActive (false);
		lose8.SetActive (false);
		lose9.SetActive (false);
		lose10.SetActive (false);
	}

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();


	}


	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		if (ttempo == true) {
			timer -= Time.deltaTime;
			int minutes = (int)(timer / 60);
			int seconds = (int)(timer % 60);
			text.text = string.Format("{0:0}:{1:00}", minutes, seconds);
		}

		if (timer <= 0 && ttempo) {
				RandomLose();
		}
	}

	public void RandomLose(){

		rand = Random.Range(1,10);
		ttempo = false;
		Time.timeScale = 0;

		LoseSound.Play ();

		if(rand == 1){
			lose1.SetActive (true);
		}

		if(rand == 2){
			lose2.SetActive (true);
		}

		if(rand == 3){
			lose3.SetActive (true);
		}

		if(rand == 4){
			lose4.SetActive (true);
		}

		if(rand == 5){
			lose5.SetActive (true);
		}

		if(rand == 6){
			lose6.SetActive (true);
		}

		if(rand == 7){
			lose7.SetActive (true);
		}

		if(rand == 8){
			lose8.SetActive (true);
		}

		if(rand == 9){
			lose9.SetActive (true);
		}

		if(rand == 10){
			lose10.SetActive (true);
		}

	}
}
