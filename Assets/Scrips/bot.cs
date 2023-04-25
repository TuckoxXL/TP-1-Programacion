using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bot : MonoBehaviour
{
    public humano humanoScript;
    public string nuevoNombre;
  
    void Start()
    {
        humanoScript = GameObject.FindWithTag("humano").GetComponent<humano>();
        

    }

    public void Saludar()
    {
        humanoScript.Nombre = nuevoNombre;
        Debug.Log(humanoScript.nombre);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("botFulvo"))
        {
            Saludar();
        }
    }
}
