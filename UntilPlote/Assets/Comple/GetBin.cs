using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBin : MonoBehaviour
{
    public bool nearBin;

    public static bool getBin;


    public GameObject Bin;

    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getBin)
        {
            if (nearBin)
            {
                //Eボタンを押されたら
                if (Input.GetKey(KeyCode.E))
                {
                    //ビン消す
                    Bin.SetActive(false);
                    Window.SetActive(false);
                    getBin = true;
                }
            }
        }



    }

    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //プレイヤーが近づいてきて
        if (other.gameObject.CompareTag("Player"))
        {

            nearBin = true;
            Window.SetActive(true);


        }

    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearBin = false;
            Window.SetActive(false);
        }
    }
}
