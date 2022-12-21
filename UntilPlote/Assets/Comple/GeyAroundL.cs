using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyAroundL : MonoBehaviour
{
    public bool nearKeyL;

    public static bool getKeyL;


    public GameObject KeyLD;

    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getKeyL)
        {
            if (nearKeyL)
            {
                //Eボタンを押されたら
                if (Input.GetKey(KeyCode.E))
                {
                    //鍵消す
                    KeyLD.SetActive(false);
                    Window.SetActive(false);
                    getKeyL = true;
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
            Window.SetActive(true);
            nearKeyL = true;

        }
    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearKeyL = false;
        }
        Window.SetActive(false);

    }
}
