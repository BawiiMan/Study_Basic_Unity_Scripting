﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've Washed a cup!");
            cupsInTheSink--;
        }
    }
}
