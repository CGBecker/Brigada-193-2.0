using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	public static int score;

	public Wayfireman fire1;
	Text text;                

	public float temp = 0;
	public Botoes botao;

    public GameObject[] LoseS;
    private int randomizer;
    public AudioSource LoseSound;


    void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();

		// Reset the score.
		score = 250;
	}


	void Update (){
		
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "" + score;

		if (score < 0) {
			temp += Time.deltaTime;
			//botao.disableAllButtonsPopUp();
			if(temp>=5){
				GameOver ();
                temp = 0;
                score = 1;
			}
		}
	}

	public void GameOver(){
        randomizer = Random.Range(0, LoseS.Length);
        LoseS[randomizer].SetActive(true);
        LoseSound.Play();
        Time.timeScale = 0;

    }
}