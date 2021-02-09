using UnityEngine;
using System.Collections;

public class LevelsGo : MonoBehaviour {

    public GameObject Go;
    public GameObject Seta1;
    public GameObject Seta2;


	void Start () {

        Go.SetActive(true);
        Seta1.SetActive(false);
        Seta2.SetActive(false);

	}

    public void Click() {

        Go.SetActive(false);
        Seta1.SetActive(true);
        Seta2.SetActive(true);
    }
	
}
