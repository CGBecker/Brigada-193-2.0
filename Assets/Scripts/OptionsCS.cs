using UnityEngine;
using System.Collections;

public class OptionsCS : MonoBehaviour {

	public GameObject OptionsPanel;
	public GameObject SoundOn;
	public GameObject SoundOff;
    

	public bool isOn;

	public bool SoundIsOn = true;

	private bool OnCredits;
	public GameObject Credits;

    public Animator Camera;
    public GameObject Back;
    private bool IsOn = false;
    private float timer;


    public void Options(){

        Camera.SetBool("IsOpcoesOn", true);

        IsOn = true;

    }

    void Update()
    {

        if (IsOn == true)
        {
            timer += Time.deltaTime;

        }

        if (timer >= 1.2F)
        {
            Back.SetActive(true);
            IsOn = false;
            timer = 0;

        }
    }

    public void GoBack() {
        Camera.SetBool("IsOpcoesOn", false);

        Back.SetActive(false);
    }

}
