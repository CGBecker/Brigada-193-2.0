using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SubMenuProximo : MonoBehaviour {


    public SubMenuVoltar VoltarCS;
    public Animator animatorDaCamera;

	public AudioSource Selecao;

    public void Click() {

		Selecao.Play ();

        if (VoltarCS.Action == 0) {
            animatorDaCamera.SetInteger("World", 2);

        }
        if (VoltarCS.Action == 1) {
            animatorDaCamera.SetInteger("World", 3);

        }
        if (VoltarCS.Action == 2) {
            
        }

        VoltarCS.Action += 1;

        if (VoltarCS.Action > 2) { VoltarCS.Action = 2; }
    
    }
}
