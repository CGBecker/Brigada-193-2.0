using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public static class SaveRanking {
	
	public static int LevelProgress;

	public static int SomOn;

	public static int Bloco1StarINT;
	public static int Bloco2StarINT;
	public static int Bloco3StarINT;
	public static int Bloco4StarINT;
	public static int Bloco5StarINT;
    public static int Bloco6StarINT;
    public static int Bloco7StarINT;
    public static int Bloco8StarINT;
    public static int Bloco9StarINT;
    public static int Bloco10StarINT;
    public static int Bloco11StarINT;
    public static int Bloco12StarINT;
    public static int Bloco13StarINT;
    public static int Bloco14StarINT;
    public static int Bloco15StarINT;

	public static void SaveGame(){  

		if (Bloco1StarINT > 3) {Bloco1StarINT = 3;}
		if (Bloco2StarINT > 3) {Bloco2StarINT = 3;}
		if (Bloco3StarINT > 3) {Bloco3StarINT = 3;}
		if (Bloco4StarINT > 3) {Bloco4StarINT = 3;}
		if (Bloco5StarINT > 3) {Bloco5StarINT = 3;}
        if (Bloco6StarINT > 3) {Bloco6StarINT = 3;}
        if (Bloco7StarINT > 3) {Bloco7StarINT = 3;}
        if (Bloco8StarINT > 3) {Bloco8StarINT = 3;}
        if (Bloco9StarINT > 3) {Bloco9StarINT = 3;}
        if (Bloco10StarINT > 3) {Bloco10StarINT = 3;}
        if (Bloco11StarINT > 3) {Bloco11StarINT = 3;}
        if (Bloco12StarINT > 3) {Bloco12StarINT = 3;}
        if (Bloco13StarINT > 3) {Bloco13StarINT = 3;}
        if (Bloco14StarINT > 3) {Bloco14StarINT = 3;}
        if (Bloco15StarINT > 3) {Bloco15StarINT = 3;}


        PlayerPrefs.SetInt("Bloco1StarINT", Bloco1StarINT);
        PlayerPrefs.SetInt("Bloco2StarINT", Bloco2StarINT);
        PlayerPrefs.SetInt("Bloco3StarINT", Bloco3StarINT);
        PlayerPrefs.SetInt("Bloco4StarINT", Bloco4StarINT);
        PlayerPrefs.SetInt("Bloco5StarINT", Bloco5StarINT);
        PlayerPrefs.SetInt("Bloco6StarINT", Bloco6StarINT);
        PlayerPrefs.SetInt("Bloco7StarINT", Bloco7StarINT);
        PlayerPrefs.SetInt("Bloco8StarINT", Bloco8StarINT);
        PlayerPrefs.SetInt("Bloco9StarINT", Bloco9StarINT);
        PlayerPrefs.SetInt("Bloco10StarINT", Bloco10StarINT);
        PlayerPrefs.SetInt("Bloco11StarINT", Bloco11StarINT);
        PlayerPrefs.SetInt("Bloco12StarINT", Bloco12StarINT);
        PlayerPrefs.SetInt("Bloco13StarINT", Bloco13StarINT);
        PlayerPrefs.SetInt("Bloco14StarINT", Bloco14StarINT);
        PlayerPrefs.SetInt("Bloco15StarINT", Bloco15StarINT);

        PlayerPrefs.SetInt("LevelProgress", LevelProgress);

		PlayerPrefs.SetInt ("SomOn", SomOn);

        

    }

	public static void LoadGame(){

		SomOn = PlayerPrefs.GetInt ("SomOn");

        LevelProgress = PlayerPrefs.GetInt("LevelProgress");

        Bloco1StarINT = PlayerPrefs.GetInt("Bloco1StarINT");
        Bloco2StarINT = PlayerPrefs.GetInt("Bloco2StarINT");
        Bloco3StarINT = PlayerPrefs.GetInt("Bloco3StarINT");
        Bloco4StarINT = PlayerPrefs.GetInt("Bloco4StarINT");
        Bloco5StarINT = PlayerPrefs.GetInt("Bloco5StarINT");
        Bloco6StarINT = PlayerPrefs.GetInt("Bloco6StarINT");
        Bloco7StarINT = PlayerPrefs.GetInt("Bloco7StarINT");
        Bloco8StarINT = PlayerPrefs.GetInt("Bloco8StarINT");
        Bloco9StarINT = PlayerPrefs.GetInt("Bloco9StarINT");
        Bloco10StarINT = PlayerPrefs.GetInt("Bloco10StarINT");
        Bloco11StarINT = PlayerPrefs.GetInt("Bloco11StarINT");
        Bloco12StarINT = PlayerPrefs.GetInt("Bloco12StarINT");
        Bloco13StarINT = PlayerPrefs.GetInt("Bloco13StarINT");
        Bloco14StarINT = PlayerPrefs.GetInt("Bloco14StarINT");
        Bloco15StarINT = PlayerPrefs.GetInt("Bloco15StarINT");

    }
}
