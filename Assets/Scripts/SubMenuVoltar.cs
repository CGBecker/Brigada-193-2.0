using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SubMenuVoltar : MonoBehaviour {

    public int Action = 0;
    public Animator animatorDaCamera;

	public AudioSource Selecao;

    public void Click()
    {

		Selecao.Play ();

        if (Action == 0) {
            SceneManager.LoadScene(1);
            
        }
        if (Action == 1) {
            animatorDaCamera.SetInteger("World", 1);
        }
        if (Action == 2) {
            animatorDaCamera.SetInteger("World", 2);

        }

        Action -= 1;

        if (Action < 0) { Action = 0; }

    }
}
