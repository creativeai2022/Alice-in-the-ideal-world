using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class DoorGateThrow : MonoBehaviour
{
    //ゲートにいる
    public bool nearGate;

    //今開けようとしているドアが正しいかどうかの判定
    public static bool isThisDoorTrue;

    //「通る：E」のウィンドウ
    public GameObject Window;

    //ドアがたくさんある部屋に入るためのドアの位置
    public static Vector3 FirstPosition;

    // 入り口のドアのGameObject
    public GameObject EnterDoor;

    // 操作するキャラクター（アリス）
    public GameObject Player;

    //CanvasGroup型の変数aを宣言　あとでCanvasGroupをアタッチする
    public CanvasGroup a;

    // アルファ値の変更
    //FadeIn-FadeOutの実装のため
    private float valueAluph = 0f;
    private float value = 0.3f;
    private bool fade = false;

    // Start is called before the first frame update
    void Start()
    {
        //入ってくるドアの位置を取得
        FirstPosition = EnterDoor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ゲートに入ってれば
        if (nearGate)
        {
            //「通る：E」の表示
            Window.SetActive(true);

            //Eキーが押されたら
            if (Input.GetKeyDown(KeyCode.E))
            {
                //FadeIn-FadeOutを始める
                StartCoroutine("Fade");

                //もし、今近くにいるドアのタグが、ランダムに決められた正しいドアタグと等しいならば
                if (this.gameObject.CompareTag(RandomDoorNumber.doorNumber))
                {
                    //正しいドアであるとする
                    isThisDoorTrue = true;
                    //Debug.Log("正しい");

                    //次のシーンへ移動
                    FadeManager.Instance.LoadScene("Castle_first", 1.0f);


                    //QuitGame();
                }


                else
                {
                    //正しくないとする
                    isThisDoorTrue = false;
                    //Debug.Log("正しくない");

                    //違うなら入ってきたドアへ後戻り
                    Player.transform.position = FirstPosition;

                    //ゲートに近いかどうかの判定リセット
                    nearGate = false;

                    //「通る：E」の非表示
                    Window.SetActive(false);
                }
            }
        }
    }


    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //プレイヤーが近づいてきたら
        if (other.gameObject.CompareTag("Player"))
        {
            //ゲートに近いとする
            nearGate = true;

            //「通る：E」の表示
            Window.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //プレイヤーが離れたら
        if (other.gameObject.CompareTag("Player"))
        {
            //ゲートに近くないとする
            nearGate = false;

            //「通る：E」の非表示
            Window.SetActive(false);
        }
    }

    IEnumerator Fade1()
    {
        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更

        yield return new WaitForSeconds(0.1f); //待つ時間

        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更
    }

    IEnumerator Fade2()
    {
        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更

        yield return new WaitForSeconds(0.1f); //待つ時間

        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更
    }

    IEnumerator Fade3()
    {
        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更

        yield return new WaitForSeconds(0.1f); //待つ時間

        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更
    }

    IEnumerator Fade4()
    {
        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更

        yield return new WaitForSeconds(0.1f); //待つ時間

        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更
    }

    IEnumerator Fade5()
    {
        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更

        yield return new WaitForSeconds(0.1f); //待つ時間

        valueAluph += value;
        a.alpha = valueAluph;//変数aのalpha値を変更
    }

    IEnumerator Fade()
    {
        //暗くする
        StartCoroutine("Fade1");
        StartCoroutine("Fade2");
        StartCoroutine("Fade3");
        StartCoroutine("Fade4");
        StartCoroutine("Fade5");


        yield return new WaitForSeconds(0.1f); //待つ時間

        //変化値を逆転させて
        value = -1f * value;

        //明るくする
        StartCoroutine("Fade1");
        StartCoroutine("Fade2");
        StartCoroutine("Fade3");
        StartCoroutine("Fade4");
        StartCoroutine("Fade5");
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
        Application.Quit();//ゲームプレイ終了
#endif
    }


}
