using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cats : MonoBehaviour
{
    //「白兎：F」のウィンドウ
    public GameObject Window;

    private bool isNear_WhiteRabbit;

    void Start()
    {

    }

    void Update()
    {
        if (isNear_WhiteRabbit)
        {
            //Fキーが押された
            if (Input.GetKey(KeyCode.F))
            {

                SceneManager.LoadScene("Scenario4-1");

            }
        }

    }

    //白兎の周囲のオブジェクトに侵入してきたら
    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //侵入してきたもののタグが"Player"なら
        if (other.gameObject.CompareTag("Player"))
        {
            //「白兎：F」の表示
            Window.SetActive(true);

            isNear_WhiteRabbit = true;
        }

    }

    //白兎の周囲のオブジェクトが離れたら
    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //離れたもののタグが"Player"なら
        if (other.gameObject.CompareTag("Player"))
        {
            //「白兎：F」の非表示
            Window.SetActive(false);

            isNear_WhiteRabbit = false;
        }

    }
}
