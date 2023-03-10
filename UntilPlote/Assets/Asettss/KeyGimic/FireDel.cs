using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FireDel : MonoBehaviour
{
    public static bool isBurning;//暖炉が燃えているかどうかの判断
    public bool nearFire;
    public GameObject Fire;
    public GameObject KeyR;

    public GameObject Window;
    private Vector3 SmallSize = new Vector3(0.01f, 0.01f, 0.01f);


    // Start is called before the first frame update
    void Start()
    {
        isBurning = true;
    }

    void Update()
    {
        if (isBurning)
        {
            if (nearFire)
            {
                //Eボタンを押されたら
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("押された");
                    nearFire = false;
                    Fire.transform.DOScale(new Vector3(0.0f, 0.0f, 0.0f), 2.5f);
                }
            }

            if (Fire.transform.localScale.x < SmallSize.x)
            {
                Debug.Log("消す");
                //暖炉を消す
                Fire.SetActive(false);
                isBurning = false;
                Window.SetActive(false);
                KeyR.SetActive(true);

            }
        }
    }



    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (isBurning)
        {
            Window.SetActive(true);

            Debug.Log("いぇｓ");

            //プレイヤーが近づいてきて
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("近い");
                //暖炉が燃えてるとき
                if (isBurning)
                {
                    Debug.Log("燃えてる");
                    nearFire = true;
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("離れた");
            Debug.Log("燃えてる");
            nearFire = false;
            Window.SetActive(false);
        }
    }
}
