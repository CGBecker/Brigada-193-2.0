using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Botoes : MonoBehaviour {

	public Button b1,b2,b3,b4,b5;
	public Image cdb3;

	public float coolDownTime = 3;


	public Wayfiretruck timer, timer2, tp;

	// Use this for initialization
	void Start () {
	
		cdb3.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void disableAllButtons(){    
		
		b1.interactable = false;
		b2.interactable = false;
		//b3.gameObject.SetActive(false);
		b3.interactable = false;

		//cdb3.fillAmount = MapTime(cb3.fillAmmount, 0, 1, 

//		cdb3.fillAmount -= 0.25f;
//		cdb3.fillAmount -= timer2.temp/100;
	

	}

	public void chainsawOff(){
	
		b2.interactable = false;
	}


	public void enableAllButtons(){

		b1.interactable = true;
		b2.interactable = true;
		b3.interactable = true;
		b4.interactable = true;
		b5.interactable = true;
	}

//	private float MapTime(float value, float istart, float istop, float ostart, float ostop) {
//		return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
//	}

	public void disableAllButtonsPopUp (){

		b1.interactable = false;
		b2.interactable = false;
		b3.interactable = false;
		b4.interactable = false;
		b5.interactable = false;
	}
}
