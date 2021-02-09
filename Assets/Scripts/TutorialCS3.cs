using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialCS3 : MonoBehaviour {

	private int Part = 0;

	public GameObject Part1;
	public GameObject Part2;
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



		}

		if (Part == 1) {
            randomizer = Random.Range(0, Load.Length);
            Load[randomizer].SetActive(true);
            Part1.SetActive(false);
            Part2.SetActive(false);

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

        Botao1.SetActive(false);

        isLoading = true;


    }

    public void Update()
    {

        if (isLoading == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 2)
        {
            SceneManager.LoadSceneAsync(8);
            isLoading = false;
            timer = 0F;
        }
    }
}
