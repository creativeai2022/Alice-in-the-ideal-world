using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment : MonoBehaviour
{
    public static bool neverBig = false;
    public static bool neverSmall = false;

    /*
    public bool small;
    public bool big;
    public bool bin;
    */

    public GameObject inCakeBox;
    public GameObject KeyL;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        bin = GetBin.getBin;
        Debug.Log(bin);
        */

        if (!neverBig)
        {
            //�傫���Ȃ������Ƃ����邩
            if (GetCake.getCake)
            {
                if (Input.GetKey(KeyCode.R))
                {
                    neverBig = true;
                    //big = true;
                }

            }
        }

        if (!neverSmall)
        {
            //�������Ȃ������Ƃ����邩
            if (GetBin.getBin)
            {
                if (Input.GetKey(KeyCode.T))
                {
                    neverSmall = true;
                    inCakeBox.SetActive(true);
                    KeyL.SetActive(true);

                    //small = true;
                }

            }
        }

    }
}
