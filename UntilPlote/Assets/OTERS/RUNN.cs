using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUNN : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 force;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = new Vector3(0f,0f,20f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(force);
    }
}
