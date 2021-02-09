using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RandomLoadScreen : MonoBehaviour {

	public GameObject[] Load;

	private int randomizer;

	private float timer;

    private bool isLoading = false;


	void Start () {

		randomizer = Random.Range (0, Load.Length);


		Load [randomizer].SetActive (true);
	
	}
	

	void Update () {

        if (isLoading == false)
        {
            timer += Time.deltaTime;
        }
		if (timer >= 5) {
			SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().buildIndex + 1);
            isLoading = true;
            timer = 0F;
		}
	}
}
