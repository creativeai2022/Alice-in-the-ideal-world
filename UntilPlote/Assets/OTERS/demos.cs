using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demos : MonoBehaviour
{
    public static bool deth;

    public GameObject White;
    public GameObject Wind;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!deth)
        {
            White.SetActive(true);
        }
        else
        {
            White.SetActive(false);
            Wind.SetActive(false);
        }

    }
}
