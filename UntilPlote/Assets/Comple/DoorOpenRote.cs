using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class DoorOpenRote : MonoBehaviour
{
    //回転させたい角度
    public float RotationValue;

    //ドアに近いかどうかの判定
    public bool nearThisDoor;

    //各ドアを開けたか同課の判定
    public bool isOpen1;
    public bool isOpen2;
    public bool isOpen3;
    public bool isOpen4;
    public bool isOpen5;

    //このスクリプトをアタッチするドアオブジェクト
    public GameObject ThisDoorObject;

    // 通過判定のゲームオブジェクト
    public GameObject DoorGate;

    //「開ける：E」のウィンドウ
    public GameObject Window;

    void Start()
    {
    }

    void Update()
    {
        //ドアに近いとき
        if (nearThisDoor)
        {
            //Debug.Log("近い");

            //Eボタンを押されたら
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Debug.Log("押された");

                //開けられる状態であるなら
                if (CanYouOpen.canOpen)
                {

                    //１個目のランダムドア
                    if (ThisDoorObject.CompareTag("1"))
                    {

                        //ドアが開いてなければ
                        if (!isOpen1)
                        {
                            //ドアを開けたことにする
                            isOpen1 = true;

                            //「開ける：E」を消す
                            Window.SetActive(false);

                        }
                    }

                    //２個目のランダムドア
                    else if (ThisDoorObject.CompareTag("2"))
                    {
                        //ドアが開いてなければ
                        if (!isOpen2)
                        {
                            //ドアを開けたことにする
                            isOpen2 = true;

                            //「開ける：E」を消す
                            Window.SetActive(false);

                        }
                    }

                    //３個目のランダムドア
                    else if (ThisDoorObject.CompareTag("3"))
                    {
                        //ドアが開いてなければ
                        if (!isOpen3)
                        {
                            //ドアを開けたことにする
                            isOpen3 = true;

                            //「開ける：E」を消す
                            Window.SetActive(false);

                        }
                    }

                    //４個目のランダムドア
                    else if (ThisDoorObject.CompareTag("4"))
                    {
                        //ドアが開いてなければ
                        if (!isOpen4)
                        {
                            //ドアを開けたことにする
                            isOpen4 = true;

                            //「開ける：E」を消す
                            Window.SetActive(false);

                        }
                    }

                    //５個目のランダムドア
                    else if (ThisDoorObject.CompareTag("5"))
                    {
                        //ドアが開いてなければ
                        if (!isOpen5)
                        {
                            //ドアを開けたことにする
                            isOpen5 = true;

                            //「開ける：E」を消す
                            Window.SetActive(false);

                        }
                    }

                    //コルーチンの使用
                    StartCoroutine("CanThrrow");

                }

                //Debug.Log("開けた");

            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //１個目のランダムドア
        if (ThisDoorObject.CompareTag("1"))
        {
            //ドアが開いてなければ
            if (!isOpen1)
            {
                // もし衝突した相手オブジェクトのTagが"Player"ならば
                if (collision.gameObject.CompareTag("Player"))
                {
                    //「開ける：E」の表示
                    Window.SetActive(true);
                    //Debug.Log("触れた");

                    //ドアに近いかどうかのBoolを更新定
                    nearThisDoor = true;

                }
            }
        }

        //２個目のランダムドア
        else if (ThisDoorObject.CompareTag("2"))
        {
            //ドアが開いてなければ
            if (!isOpen2)
            {
                // もし衝突した相手オブジェクトのTagが"Player"ならば
                if (collision.gameObject.CompareTag("Player"))
                {
                    //「開ける：E」の表示
                    Window.SetActive(true);
                    //Debug.Log("触れた");

                    //ドアに近いかどうかのBoolを更新定
                    nearThisDoor = true;

                }
            }
        }

        //３個目のランダムドア
        else if (ThisDoorObject.CompareTag("3"))
        {
            //ドアが開いてなければ
            if (!isOpen3)
            {
                // もし衝突した相手オブジェクトのTagが"Player"ならば
                if (collision.gameObject.CompareTag("Player"))
                {
                    //「開ける：E」の表示
                    Window.SetActive(true);
                    //Debug.Log("触れた");

                    //ドアに近いかどうかのBoolを更新定
                    nearThisDoor = true;

                }
            }
        }

        //４個目のランダムドア
        else if (ThisDoorObject.CompareTag("4"))
        {
            //ドアが開いてなければ
            if (!isOpen4)
            {
                // もし衝突した相手オブジェクトのTagが"Player"ならば
                if (collision.gameObject.CompareTag("Player"))
                {
                    //「開ける：E」の表示
                    Window.SetActive(true);
                    //Debug.Log("触れた");

                    //ドアに近いかどうかのBoolを更新定
                    nearThisDoor = true;

                }
            }
        }

        //５個目のランダムドア
        else if (ThisDoorObject.CompareTag("5"))
        {
            //ドアが開いてなければ
            if (!isOpen5)
            {
                // もし衝突した相手オブジェクトのTagが"Player"ならば
                if (collision.gameObject.CompareTag("Player"))
                {
                    //「開ける：E」の表示
                    Window.SetActive(true);
                    //Debug.Log("触れた");

                    //ドアに近いかどうかのBoolを更新定
                    nearThisDoor = true;

                }
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        //１個目のランダムドア
        if (ThisDoorObject.CompareTag("1"))
        {
            //ドアが開いてなければ
            if (!isOpen1)
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

        //２個目のランダムドア
        else if (ThisDoorObject.CompareTag("2"))
        {
            //ドアが開いてなければ
            if (!isOpen2)
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

        //３個目のランダムドア
        else if (ThisDoorObject.CompareTag("3"))
        {
            //ドアが開いてなければ
            if (!isOpen3)
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

        //４個目のランダムドア
        else if (ThisDoorObject.CompareTag("4"))
        {
            //ドアが開いてなければ
            if (!isOpen4)
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

        //５個目のランダムドア
        else if (ThisDoorObject.CompareTag("5"))
        {
            //ドアが開いてなければ
            if (!isOpen5)
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

    //ドアを開けてから少し待ってゲートが出現、進めるようになる
    //ためのコルーチン作成
    IEnumerator CanThrrow()
    {
        //ドアを0.5秒で開ける
        transform.DORotate(new Vector3(0, RotationValue, 0), 0.5f);

        yield return new WaitForSeconds(0.5f); //待つ時間

        //通過できるようにする
        DoorGate.SetActive(true);
    }
}
