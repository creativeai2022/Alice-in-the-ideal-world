using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;



public class OpenClose : MonoBehaviour
{
    //ドアに近いかどうかの判定
    public bool nearThisDoor;

    //ドアを開けたか同課の判定
    public bool isOpen;

    //今開けようとしているドアが正しいかどうかの判定
    public static bool isThisDoorTrue;

    //「開ける：E」のウィンドウ
    public GameObject Window;

    //ドアがたくさんある部屋に入るためのドアの位置
    public static Vector3 FirstPosition;

    // 入り口のドアのGameObject
    public GameObject EnterDoor;

    // 操作するキャラクター（アリス）
    public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        //入ってくるドアの位置を取得
        FirstPosition = EnterDoor.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //ドアに近いとき
        if (nearThisDoor)
        {
            Debug.Log("近い");

            //Eボタンを押されたら
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("押された");

                //ドアが開いてなければ
                if (!isOpen)
                {
                    Debug.Log("開けた");

                    //ドアを開けたことにする
                    isOpen = true;

                    //ドアを0.5秒で開ける
                    transform.DORotate(new Vector3(0,-160f, 0), 0.5f);

                    //「開ける：E」を消す
                    Window.SetActive(false);

                }
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log("押された");

                //ドアが開いてれば
                if (isOpen)
                {
                    Debug.Log("開けた");

                    //ドアを開けたことにする
                    isOpen = false;

                    //ドアを0.5秒で開ける
                    transform.DORotate(new Vector3(0, 30f, 0), 0.5f);

                    //「開ける：E」を消す
                    Window.SetActive(false);

                }
            }


        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isOpen)
        {
            // もし衝突した相手オブジェクトのTagが"Player"ならば
            if (collision.gameObject.CompareTag("Player"))
            {
                //「開ける：E」の表示
                Window.SetActive(true);
                Debug.Log("触れた");

                //ドアに近いかどうかのBoolを更新定
                nearThisDoor = true;

            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (!isOpen)
        {
            // もし接触から離れた相手オブジェクトのTagが"Player"ならば
            if (collision.gameObject.CompareTag("Player"))
            {
                //「開ける：E」を消す
                Window.SetActive(false);

                //ドアに近いかどうかのBoolを更新
                nearThisDoor = false;

            }
        }
    }
}