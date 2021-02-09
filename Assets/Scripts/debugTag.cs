using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class debugTag : MonoBehaviour {


	private static string SelectedTag = "fogo";

	[MenuItem("Helpers/Select By Tag")]
	public static void SelectObjectsWithTag(){
		GameObject[] objs = GameObject.FindGameObjectsWithTag (SelectedTag);
		Selection.objects = objs;
	
	}
}
