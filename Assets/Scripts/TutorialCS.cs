using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialCS : MonoBehaviour {

	private int Part = 0;

	public GameObject Part1;
	public GameObject Part2;
	public GameObject Part3;
	public GameObject Part4;
	public GameObject Part5;
	public GameObject Botao1;
    public GameObject Botao2;

    public AudioSource selecao;


    public GameObject[] Load;
    private int randomizer;
    private float timer;
    private bool isLoading = false;


    public void OnClickNext(){

		selecao.Play ();

		print ("Click");

		if (Part == 0) {

			Part1.SetActive (false);
			Part2.SetActive (true);
			Part3.SetActive (false);
			Part4.SetActive (false);
			Part5.SetActive (false);
			


		}

		if (Part == 1) {

			Part1.SetActive (false);
			Part2.SetActive (false);
			Part3.SetActive (true);
			Part4.SetActive (false);
			Part5.SetActive (false);
			


		}

		if (Part == 2) {

			Part1.SetActive (false);
			Part2.SetActive (false);
			Part3.SetActive (false);
			Part4.SetActive (true);
			Part5.SetActive (false);
			

		}

		if (Part == 3) {

			Part1.SetActive (false);
			Part2.SetActive (false);
			Part3.SetActive (false);
			Part4.SetActive (false);
			Part5.SetActive (true);
			


		}
        
		if (Part == 4) {

            randomizer = Random.Range(0, Load.Length);
            Load[randomizer].SetActive(true);
            Part1.SetActive(false);
            Part2.SetActive(false);
            Part3.SetActive(false);
            Part4.SetActive(false);
            Part5.SetActive(false);
            Botao1.SetActive(false);

            isLoading = true;
           
		
		}

		Part++;
	
	}

	public void OnClickBack(){

		selecao.Play ();

        randomizer = Random.Range(0, Load.Length);
        Load[randomizer].SetActive(true);
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(false);
        Part4.SetActive(false);
        Part5.SetActive(false);        
        Botao1.SetActive(false);

        isLoading = true;


    }


    public void Update() {

        if (isLoading == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 2)
        {
            SceneManager.LoadSceneAsync(4);
            isLoading = false;
            timer = 0F;
        }
    }
}
