using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTimes : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;
    //public Light light;

    void Update()
    {
        //countdown -= Time.deltaTime;
        //if (countdown <= 0.0f)
            //light.enabled = false;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
    }
}
