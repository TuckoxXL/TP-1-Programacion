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
        Debug.Log("hola " + humanoScript.nombre + " ahora sos " + nuevoNombre);
        humanoScript.Nombre = nuevoNombre;
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("humano"))
        {           
            Saludar();
        }
    }
}
