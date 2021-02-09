using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


public class LevelController1 : MonoBehaviour {

	private GameObject fogo;
	public GameObject popwin;
	public bool temp = false;
	public float tempo = 0;

	private bool isOver = false;

	public AudioSource WinSound;

   
	public GameObject BotaoChainsawOn;
	public GameObject BotaoChainsawOff;
    

	//List de objetos
	public List<GameObject> listaDeFogo = new List<GameObject>();

	public List<GameObject> listaDeCoelho = new List<GameObject>();

	public List<GameObject> listaDeToco = new List<GameObject> ();

	void Start () {

      
		BotaoChainsawOn = GameObject.Find ("Lumberjack (1)");
		BotaoChainsawOff = GameObject.Find ("LumberjackCooldown");

		popwin.SetActive(false);

		listaDeFogo = GameObject.FindGameObjectsWithTag ("fogo").ToList ();
		UnityEngine.Debug.Log("Lista de fogo: " + listaDeFogo.Count);

		listaDeCoelho = GameObject.FindGameObjectsWithTag("coelho").ToList();
		//print ("Lista de coelhos: " + listaDeCoelho.Count);

		listaDeToco = GameObject.FindGameObjectsWithTag ("toco").ToList ();
		print ("Lista de tocos: " + listaDeToco.Count);
	}

	//Chama do script do fogo.
	public void TakeFromList(GameObject fogo)
	{
		//Tira da lista
		if (listaDeFogo.Contains (fogo)) {			
			listaDeFogo.Clear();
			listaDeFogo = GameObject.FindGameObjectsWithTag ("fogo").ToList ();
			listaDeFogo.Remove (fogo);
			print ("Tirando da lista de fogo, count: "+ listaDeFogo.Count);
		}
	}


	public void TakeFromList2(GameObject coelho)
	{
		//print ("Tirando da lista de coelho");
		if (listaDeCoelho.Contains (coelho)) {
			listaDeCoelho.Remove (coelho);

		}
	}

	public void TakeFromList3(GameObject toco){	

		if (listaDeToco.Contains (toco)) {
			listaDeToco.Remove (toco);
		}
		if (listaDeToco.Count <= 0) {
			BotaoChainsawOn.SetActive (false);
			BotaoChainsawOff.SetActive (true);
		}
		//print ("tirando da lista de toco");
	
	}




	void Update () {

		//UnityEngine.Debug.Log ("Lista de fogo: " + listaDeFogo.Count);

		/*if (SceneManager.GetActiveScene ().buildIndex == 28 && listaDeFogo.Count <= 3) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 26 && listaDeFogo.Count <= 7) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 24 && listaDeFogo.Count <= 5) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 22 && listaDeFogo.Count <= 3) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 20 && listaDeFogo.Count <= 2) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 18 && listaDeFogo.Count <= 3) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 16 && listaDeFogo.Count <= 4) {
			listaDeFogo.Clear ();
		}
		if (SceneManager.GetActiveScene ().buildIndex == 14 && listaDeFogo.Count <= 3) {
			listaDeFogo.Clear ();
		}*/

		if (listaDeFogo.Count == 0 && isOver == false) {
			
			if (listaDeCoelho.Count == 0) {
				if (SceneManager.GetActiveScene ().buildIndex == 4) {SaveRanking.Bloco1StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 6) {SaveRanking.Bloco2StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 8) {SaveRanking.Bloco3StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 10) {SaveRanking.Bloco4StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 12) {SaveRanking.Bloco5StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 14) {SaveRanking.Bloco6StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 16) {SaveRanking.Bloco7StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 18) {SaveRanking.Bloco8StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 20) {SaveRanking.Bloco9StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 22) {SaveRanking.Bloco10StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 24) {SaveRanking.Bloco11StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 26) {SaveRanking.Bloco12StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 28) {SaveRanking.Bloco13StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 30) {SaveRanking.Bloco14StarINT=3; SaveRanking.SaveGame ();}
				if (SceneManager.GetActiveScene ().buildIndex == 32) {SaveRanking.Bloco15StarINT=3; SaveRanking.SaveGame ();}
			}
			if (listaDeCoelho.Count == 1) {
				if (SceneManager.GetActiveScene ().buildIndex == 4) {if (global::SaveRanking.Bloco1StarINT < 3) {SaveRanking.Bloco1StarINT = 2;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 6) {if (global::SaveRanking.Bloco2StarINT < 3) {SaveRanking.Bloco2StarINT = 2;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 8) {if (global::SaveRanking.Bloco3StarINT < 3) {SaveRanking.Bloco3StarINT = 2;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 10) {if (global::SaveRanking.Bloco4StarINT < 3) {SaveRanking.Bloco4StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 12) {if (global::SaveRanking.Bloco5StarINT < 3) {SaveRanking.Bloco5StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 14) {if (global::SaveRanking.Bloco6StarINT < 3) {SaveRanking.Bloco6StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 16) {if (global::SaveRanking.Bloco7StarINT < 3) {SaveRanking.Bloco7StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 18) {if (global::SaveRanking.Bloco8StarINT < 3) {SaveRanking.Bloco8StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 20) {if (global::SaveRanking.Bloco9StarINT < 3) {SaveRanking.Bloco9StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 22) {if (global::SaveRanking.Bloco10StarINT < 3) {SaveRanking.Bloco10StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 24) {if (global::SaveRanking.Bloco11StarINT < 3) {SaveRanking.Bloco11StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 26) {if (global::SaveRanking.Bloco12StarINT < 3) {SaveRanking.Bloco12StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 28) {if (global::SaveRanking.Bloco13StarINT < 3) {SaveRanking.Bloco13StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 30) {if (global::SaveRanking.Bloco14StarINT < 3) {SaveRanking.Bloco14StarINT = 2; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 32) {if (global::SaveRanking.Bloco15StarINT < 3) {SaveRanking.Bloco15StarINT = 2; SaveRanking.SaveGame ();}}

			}
			if (listaDeCoelho.Count == 2) {
				if (SceneManager.GetActiveScene ().buildIndex == 4) {if (global::SaveRanking.Bloco1StarINT < 2) {SaveRanking.Bloco1StarINT = 1;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 6) {if (global::SaveRanking.Bloco2StarINT < 2) {SaveRanking.Bloco2StarINT = 1;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 8) {if (global::SaveRanking.Bloco3StarINT < 2) {SaveRanking.Bloco3StarINT = 1;	SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 10) {if (global::SaveRanking.Bloco4StarINT < 2) {SaveRanking.Bloco4StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 12) {if (global::SaveRanking.Bloco5StarINT < 2) {SaveRanking.Bloco5StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 14) {if (global::SaveRanking.Bloco6StarINT < 2) {SaveRanking.Bloco6StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 16) {if (global::SaveRanking.Bloco7StarINT < 2) {SaveRanking.Bloco7StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 18) {if (global::SaveRanking.Bloco8StarINT < 2) {SaveRanking.Bloco8StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 20) {if (global::SaveRanking.Bloco9StarINT < 2) {SaveRanking.Bloco9StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 22) {if (global::SaveRanking.Bloco10StarINT < 2) {SaveRanking.Bloco10StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 24) {if (global::SaveRanking.Bloco11StarINT < 2) {SaveRanking.Bloco11StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 26) {if (global::SaveRanking.Bloco12StarINT < 2) {SaveRanking.Bloco12StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 28) {if (global::SaveRanking.Bloco13StarINT < 2) {SaveRanking.Bloco13StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 30) {if (global::SaveRanking.Bloco14StarINT < 2) {SaveRanking.Bloco14StarINT = 1; SaveRanking.SaveGame ();}}
				if (SceneManager.GetActiveScene ().buildIndex == 32) {if (global::SaveRanking.Bloco15StarINT < 2) {SaveRanking.Bloco15StarINT = 1; SaveRanking.SaveGame ();}}
			}
			LevelOver ();
			isOver = true;
		}


		if(temp == true){
			tempo += Time.deltaTime;

			if(tempo >= 4){
				popwin.SetActive(true);
				Time.timeScale = 0;
			}
		}


	}

	void LevelOver() {
	
		UnityEngine.Debug.Log ("Level  Over");

		WinSound.Play ();

		temp = true;

		if (SceneManager.GetActiveScene ().buildIndex == 4) {

			
            if (SaveRanking.LevelProgress <= 1) {
                SaveRanking.LevelProgress = 1;
                SaveRanking.SaveGame();
                print ("LevelProgress: " + SaveRanking.LevelProgress);

            }
		}

		if (SceneManager.GetActiveScene ().buildIndex == 6) {

            if (SaveRanking.LevelProgress <= 2)
            {
                SaveRanking.LevelProgress = 2;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 8) {

            if (SaveRanking.LevelProgress <= 3)
            {
                SaveRanking.LevelProgress = 3;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 10) {

            if (SaveRanking.LevelProgress <= 4)
            {
                SaveRanking.LevelProgress = 4;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 12) {

            if (SaveRanking.LevelProgress <= 5)
            {
                SaveRanking.LevelProgress = 5;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 14) {

            if (SaveRanking.LevelProgress <= 6)
            {
                SaveRanking.LevelProgress = 6;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 16) {

            if (SaveRanking.LevelProgress <= 7)
            {
                SaveRanking.LevelProgress = 7;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 18) {

            if (SaveRanking.LevelProgress <= 8)
            {
                SaveRanking.LevelProgress = 8;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 20) {

            if (SaveRanking.LevelProgress <= 9)
            {
                SaveRanking.LevelProgress = 9;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 22) {

            if (SaveRanking.LevelProgress <= 10)
            {
                SaveRanking.LevelProgress = 10;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }

		if (SceneManager.GetActiveScene ().buildIndex == 24) {

            if (SaveRanking.LevelProgress <= 11)
            {
                SaveRanking.LevelProgress = 11;
                SaveRanking.SaveGame();
                print("LevelProgress: " + SaveRanking.LevelProgress);
            }
        }
		if (SceneManager.GetActiveScene ().buildIndex == 26) {

			if (SaveRanking.LevelProgress <= 12)
			{
				SaveRanking.LevelProgress = 12;
				SaveRanking.SaveGame();
				print("LevelProgress: " + SaveRanking.LevelProgress);
			}
		}
		if (SceneManager.GetActiveScene ().buildIndex == 28) {

			if (SaveRanking.LevelProgress <= 13)
			{
				SaveRanking.LevelProgress = 13;
				SaveRanking.SaveGame();
				print("LevelProgress: " + SaveRanking.LevelProgress);
			}
		}
		if (SceneManager.GetActiveScene ().buildIndex == 30) {

			if (SaveRanking.LevelProgress <= 14)
			{
				SaveRanking.LevelProgress = 14;
				SaveRanking.SaveGame();
				print("LevelProgress: " + SaveRanking.LevelProgress);
			}
		}
		if (SceneManager.GetActiveScene ().buildIndex == 32) {

			if (SaveRanking.LevelProgress <= 15)
			{
				SaveRanking.LevelProgress = 15;
				SaveRanking.SaveGame();
				print("LevelProgress: " + SaveRanking.LevelProgress);
			}
		}
	}

}
