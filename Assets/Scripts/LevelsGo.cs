using UnityEngine;
using System.Collections;

public class LevelsGo : MonoBehaviour {

    public GameObject Go;
    public GameObject Seta1;
    public GameObject Seta2;
    public GameObject hitByRay1;
    public GameObject hitByRay2;
    public GameObject hitByRay3;
    public GameObject hitByRay4;
    public GameObject hitByRay5;
    public GameObject Ashes;
    public GameObject Leafs;


    public void Awake()
    {
        if (global::SaveRanking.LevelProgress == 15)
        {
            Leafs.SetActive(true);
            Ashes.SetActive(false);
        }
        else 
        {
            Leafs.SetActive(false);
            Ashes.SetActive(true);
        }
    }
    void Start () {

        if (global::SaveRanking.LevelProgress == 0)
        {
            Go.SetActive(true);
            Seta1.SetActive(false);
            Seta2.SetActive(false);
            hitByRay1.layer = 2;
            hitByRay2.layer = 2;
            hitByRay3.layer = 2;
            hitByRay4.layer = 2;
            hitByRay5.layer = 2;
        }
        else
        {
            Click();
        }
	}

    public void Click() {

        Go.SetActive(false);
        Seta1.SetActive(true);
        Seta2.SetActive(true);
        hitByRay1.layer = 0;
        hitByRay2.layer = 0;
        hitByRay3.layer = 0;
        hitByRay4.layer = 0;
        hitByRay5.layer = 0;
    }
	
}
