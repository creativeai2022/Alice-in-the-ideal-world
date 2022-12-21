using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantBig : MonoBehaviour
{
    public static bool cantBig;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            cantBig = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cantBig = false;
        }
    }
}
