using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public static Vector3 pastPos;//アリスの位置を保存する変数
    public static bool isStart = false;//最初にAwakeを通ったかチェック
    public static string currentScene;

    //Startよりも先に読まれる
    //pastPosをアリスの位置で初期化
    void Awake() 
    {
        if(!isStart)//一度も読まれて無ければ作動
        {
            pastPos = transform.position;//変数初期化
            isStart = true;//チェック入れる
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        //アリスの位置の初期化
        //会話シーン・メニューシーンから戻った際にも使う
        transform.position=pastPos;
    }

    // Update is called once per frame
    void Update()
    {
        //メニュー呼び出し
        if(Input.GetKeyDown(KeyCode.Tab)){
                pastPos=transform.position;//アリスの場所記録
                //現在のシーン記録
                //メニュー等から元のシーンに戻るために使用
                currentScene=SceneManager.GetActiveScene().name;
                Debug.Log(currentScene);
                SceneManager.LoadScene("Menuscene");//シーン遷移
        }
        //会話シーン移動時に作動
        if(Input.GetKey(KeyCode.F)){
            pastPos=transform.position;//アリスの場所記録
            currentScene=SceneManager.GetActiveScene().name;//上と同じ
            Debug.Log("場所セーブした");

        }
    }
}

/*

変数宣言
public GameObject alice;//アリスのキャラクターを示してる

private Vector3 hogehoge= (0,0,0);//適当な変数座標。

↓どこかの関数内
alice.gameObject.transform.position = hogehoge;//座標変数をアリスの座標に代入

※これは仕様上できない。上のように、適当な変数を宣言して代入する必要がある。
alice.gameObject.transform.position.x = 0

*/
