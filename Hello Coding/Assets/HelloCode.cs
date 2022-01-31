﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start(){
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2.2)에서 (5,6)까지의 거리: " + distance);
    }
    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float a = x2 - x1;
        float b = y2 - y1;
        float distance = Mathf.Sqrt(a * a + b * b);
        return distance;
    }
    
}
