using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOBJsizing : MonoBehaviour
{


    private float sizeR = 1f;
    private float negativeForce = 0.01f;



    /*Vector3 minScale;
    public Vector3 maxScale;
    public bool repeatable;
    public float speed = 2f;
    public float duration = 5f;

    IEnumerator Start() {
        minScale = transform.localScale;
        while (repeatable)
        {
            yield return RepeatLerp(minScale, maxScale, duration);
            yield return RepeatLerp(maxScale, minScale, duration);
        }
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time) {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f) {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;

        }
    }*/

    void FixedUpdate()
    {
        //transform.localScale = new Vector4(Mathf.PingPong(Time.time, 1)+1, transform.localScale.x, transform.localScale.y, transform.localScale.z);
       
       

        if (sizeR >= 1f)
        {
            //negativeForce *= -1;
            negativeForce -= 0.0005f;
        }
        else {
            if (sizeR < 1f) {
                //negativeForce *= -1;
                negativeForce += 0.0005f;
            }
        }
        //print(negativeForce);
        sizeR += negativeForce;
        print(sizeR);
        transform.localScale = new Vector3(transform.localScale.x * sizeR, transform.localScale.y * sizeR, transform.localScale.z * sizeR);

    }
}
