using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humano : MonoBehaviour
{
    private Rigidbody rb;
    public float Forcemultiplier;
    public float jumforce;
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;
        float verticalforce = Input.GetAxis("Vertical") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        verticalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);
    }
}
