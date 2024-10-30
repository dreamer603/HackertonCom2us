using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linerender : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private Linemanager lineManager;

    private void Start()
    {
        
        lineManager.SetupLine(points);
    }
}
