﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionsCS : MonoBehaviour {

	public GameObject OptionsPanel;
	public GameObject SoundOn;
	public GameObject SoundOff;
    public GameObject StartObj;
    

	public bool isOn;

	public bool SoundIsOn = true;

	private bool OnCredits;
	public GameObject Credits;

    public Animator Camera;
    public GameObject Back;
    private bool IsOn = false;
    private float timer;


    public void Options(){

        // Camera.SetBool("IsOpcoesOn", true);

        if (IsOn == false)
        {
            OptionsPanel.SetActive(true);
            StartObj.layer = 2;
            IsOn = true;
           
        }else
        {
            if (IsOn == true)
            {
                OptionsPanel.SetActive(false);
                StartObj.layer = 0;
                IsOn = false;
            }
        }


    }

   public void Mute()
    {
        if(global::SaveRanking.SomOn == 0)
        {
            AudioListener.volume = 0f;
            global::SaveRanking.SomOn = 1;
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            global::SaveRanking.SaveGame();
        }
        else
        {
            AudioListener.volume = 1f;
            global::SaveRanking.SomOn = 0;
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
            global::SaveRanking.SaveGame();
        }
    }

    public void GoBack() {
        Camera.SetBool("IsOpcoesOn", false);

        Back.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void CreditsF() {

        if (Credits.activeSelf == true)
        {
            Credits.SetActive(false);
        }
        else { 
        if(Credits.activeSelf == false)
            {
                Credits.SetActive(true);
            }
        }
    }

}
