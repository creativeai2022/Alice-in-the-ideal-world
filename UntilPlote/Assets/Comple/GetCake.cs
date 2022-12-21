using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class GetCake : MonoBehaviour
{
    public static bool nearBox;

    public static bool isOpen;

    public static bool getCake;


    public GameObject Cake;


    public GameObject Window;
    public GameObject GetWindow;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getCake)
        {

            if (nearBox && !isOpen)
            {
                //Eボタンを押されたら
                if (Input.GetKey(KeyCode.E))
                {
                    StartCoroutine("CakeDelay");

                }
            }
            else if (nearBox && isOpen)
            {
                //Eボタンを押されたら
                if (Input.GetKey(KeyCode.E))
                {
                    //ケーキを手に入れる
                    Cake.SetActive(false);
                    GetWindow.SetActive(false);
                    getCake = true;
                }
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (!isOpen)
        {
            Window.SetActive(true);
        }
        else if (isOpen && !getCake)
        {
            GetWindow.SetActive(true);
        }

        //プレイヤーが近づいてきて
        if (other.gameObject.CompareTag("Player"))
        {

            nearBox = true;

        }

    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearBox = false;
            if (!isOpen)
            {
                Window.SetActive(false);
            }
            else
            {
                GetWindow.SetActive(false);
            }

        }
    }

    IEnumerator CakeDelay()
    {

        // 初めにしたいこと
        //箱を開ける
        Window.SetActive(false);
        GetWindow.SetActive(true);

        yield return new WaitForSeconds(1); //待つ時間

        // 数秒後にしたいこと
        isOpen = true;

    }
}
