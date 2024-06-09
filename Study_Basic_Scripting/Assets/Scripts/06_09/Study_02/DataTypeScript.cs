using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        //레퍼런스 유형 변수
        Transform tran = transform;
        tran.position = new Vector3(0, 5, 0);
        print("five");

        //값 유형 변수
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        this.transform.position = pos;
        print("two");
    }
}
