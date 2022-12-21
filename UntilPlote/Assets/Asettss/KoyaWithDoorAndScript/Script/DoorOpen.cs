
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorOpen : MonoBehaviour
{

    //ドアに近いかどうかの判定
    public bool nearThisDoor;

    //ドアを開けたか同課の判定
    public bool isOpen;

    //「開ける：E」のウィンドウ
    public GameObject Window;

    //「鍵がかかっています」のウィンドウ
    public GameObject RockWindow1;

    //「鍵がかかっています」のウィンドウ
    public GameObject RockWindow2;

    public bool ver = false;

    //ドアが回転する値
    public float RotateValue;

    //ドアが開くのにかかる演出時間
    public float RotateTime;



    // Update is called once per frame
    void Update()
    {
        //ドアに近いとき
        if (nearThisDoor)
        {
            //Eボタンを押されたら
            if (Input.GetKey(KeyCode.E))
            {

                //ドアが開いてなかったら
                if (!isOpen)
                {
                    ///<>
                    ///ドアにつけられたタグが「open」なら開ける処理。
                    ///ドアにつけられたタグが「rock」なら鍵を持ってなければ開かない処理
                    ///<>

                    //「open」がついたドアなら
                    if (gameObject.tag == "open")
                    {


                        ///<>
                        ///transform.DORotate(new Vector3(0, 220f, 0), 0.5f);
                        ///上記だと130度回転し、手前に開いた→奥に開きたい
                        ///
                        /// transform.DORotate(new Vector3(0, -220f, 0), 0.5f);
                        /// 上記だと手前に40度回転しうまくいかない
                        /// 
                        /// transform.DORotate(new Vector3(0, 10f, 0), 0.5f);
                        /// 上記だとドアの開店後の角度が－80度になった→元のドアの角度が－90であることが影響しているのか？
                        /// 
                        /// transform.DORotate(new Vector3(0, -40f, 0), 0.5f);
                        /// 理想の回転（奥に130度開いている状態）が実現した
                        ///<>

                        //ドアを0.5秒で開ける
                        transform.DORotate(new Vector3(0, RotateValue, 0), RotateTime);

                        //ドアが開いたことにする
                        isOpen = true;

                        //「開ける：E」を消す
                        Window.SetActive(false);
                    }
                    //「rock」がついたドアなら
                    else if (gameObject.tag == "rock")
                    {
                        //コルーチンの呼び出し
                        StartCoroutine("RockWin");
                    }

                }
            }

        }
    }



    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトのTagが"Player"ならば
        if (collision.gameObject.CompareTag("Player"))
        {
            //ドアが開いてなかったら
            if (!isOpen)
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
        // もし接触から離れた相手オブジェクトのTagが"Player"ならば
        if (collision.gameObject.CompareTag("Player"))
        {
            //ドアが開いてなかったら
            if (!isOpen)
            {
                //「開ける：E」を消す
                Window.SetActive(false);

                //ドアに近いかどうかのBoolを更新
                nearThisDoor = false;
            }
        }
    }

    //コルーチンの生成
    IEnumerator RockWin()
    {

        // 初めにしたいこと

        if (ver)
        {
            //「鍵が締まっている」ver1を表示
            RockWindow1.SetActive(true);
        }
        else
        {
            //「鍵が締まっている」ver2を表示
            RockWindow2.SetActive(true);
        }

        //「開ける：E」を非表示
        Window.SetActive(false);

        yield return new WaitForSeconds(1f); //１秒待つ

        // 数秒後にしたいこと

        //「鍵が締まっている」を非表示
        RockWindow1.SetActive(false);
        RockWindow2.SetActive(false);

    }
}
