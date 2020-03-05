﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ViewEdge : MonoBehaviour
{
    private const float DIAMETER_BLOCK = 1.41f;
    private static float _edgeHorizontal;

    private void Awake()
    {
        CalculateEdgeHorizontal();
    }

    private void CalculateEdgeHorizontal(){
        _edgeHorizontal = GetComponent<Camera>().ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x - DIAMETER_BLOCK;
    }

    public static bool CheckOverEdge(float horizontal){
        return horizontal > _edgeHorizontal;
    }
}
