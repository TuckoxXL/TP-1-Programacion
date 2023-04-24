using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humano : MonoBehaviour
{
    private Rigidbody rb;
    public float Forcemultiplier;
    public float jumforce;

   
    // Start is called before the first frame update
   
    public string nombre;
    public string Nombre
    {
        get { return nombre; } // get method
        set { nombre = value; } // set method
    } 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;
        //float verticalforce = Input.GetAxis("Vertical") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        //verticalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);
    }
   
}
