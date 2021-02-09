using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {

	public GameObject popuppause;
	public Botoes botao;
    public GameObject Pause;
  
	public AudioSource Selecao;

	// Use this for initialization
	void Start () {
	
		popuppause.SetActive (false);
        //Time.timeScale = 1F;
	}
	
	public void ClickPause(){

		//Selecao.Play ();
               
        Time.timeScale = 0;
		popuppause.SetActive(true);
        botao.disableAllButtonsPopUp();
        Pause.SetActive(false);
        

    }

    public void ClickResume(){  

		//Selecao.Play ();
             
        Time.timeScale = 1;
		popuppause.SetActive(false);
        botao.enableAllButtons();
        Pause.SetActive(true);
        
    }

	public void Restart(){

		//Selecao.Play ();
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	public void Quit(){

		//Selecao.Play ();
		SceneManager.LoadScene (2);
		Time.timeScale = 1;
	}
}
