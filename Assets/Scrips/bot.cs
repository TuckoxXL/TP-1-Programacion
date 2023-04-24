using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bot : MonoBehaviour
{
    public humano humanoScript;

  
    void Start()
    {
        humanoScript = GetComponent<humano>();
        
    }

    public void Saludar()
    {
       
    }
}
