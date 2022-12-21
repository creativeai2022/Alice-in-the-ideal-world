using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyR : MonoBehaviour
{
    //カギに近いか
    public bool nearKey = false;

    //落ちてる鍵
    public GameObject KeyR;

    // 鍵を取ったか
    public static bool getKeyR;

    //拾うウィンドウ
    public GameObject Window;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //カギに近いとき
        if (nearKey)
        {
            //Eボタンを押されたら
            if (Input.GetKey(KeyCode.E))
            {
                //カギとの近さを忘れる
                nearKey = false;

                //落ちてるカギを非表示にする
                KeyR.SetActive(false);

                //「拾う：E」を非表示
                Window.SetActive(false);

                //鍵を取ったことにする
                getKeyR = true;
            }
        }
    }


    public void OnCollisionEnter(Collision collision)
    {

        //プレイヤーが近づいてきたとき
        if (collision.gameObject.tag == "Player")
        {
            //「拾う：E」の表示
            Window.SetActive(true);

            //カギに近いことにする
            nearKey = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {

        //プレイヤーが離れたときに
        if (collision.gameObject.CompareTag("Player"))
        {
            //「拾う：E」の非表示
            Window.SetActive(false);

            //カギに近くないことにする
            nearKey = false;

        }
    }
}
