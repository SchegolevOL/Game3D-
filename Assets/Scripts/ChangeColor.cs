using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material _material;

    private void Start()
    {
        _material.color = new Color(100,0,100);
    }
    
    
    
    
    
    
}