using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System;

public class TalkWindowLoadText : MonoBehaviour
{

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text dataText;
    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset textAsset;
    //名前を出力するUIテキスト
    [SerializeField]
    private Text nameText;
    //　テキストファイルから読み込んだデータ
    private string loadText1;
    //　改行で分割して配列に入れる
    private string[] splitText1;
    //セリフの前で分割して配列に入れる
    private string[] splitName;
    //　現在表示中テキスト1番号
    public static int textNum1;
    //現在表示中ネーム番号
    private int nameNum;

    public GameObject TalkWindow;

    void Start()
    {
        loadText1 = textAsset.text;
        splitText1 = loadText1.Split(char.Parse("\n"));
        splitName = loadText1.Split(char.Parse("\n"));
        textNum1 = 1;
        nameNum = 0;
        //dataText.text = "";
    }

    void Update()
    {
        //　読み込んだテキストファイルの内容を表示
        if (Input.GetButtonDown("Fire1"))
        {
            if (splitText1[textNum1] != "")
            {
                dataText.text = splitText1[textNum1];
                nameText.text = splitName[nameNum];
                textNum1 = textNum1 + 2;
                nameNum = nameNum + 2;
                if (textNum1 >= splitText1.Length)
                {
                    textNum1 = 0;
                    TalkWindow.SetActive(false);
                }
            }
            else
            {
                dataText.text = "";
                textNum1++;
            }
            //　Resourcesフォルダに配置したテキストファイルの内容を表示
        }
        else if (Input.GetButtonDown("Fire2"))
        {

            if (splitText1[textNum1] != "")
            {
                textNum1 = textNum1 - 2;
                nameNum = nameNum - 2;
                dataText.text = splitText1[textNum1];
                nameText.text = splitName[nameNum];
                if (textNum1 >= splitText1.Length)
                {
                    textNum1 = 0;
                }
            }
            else
            {
                dataText.text = "";
                textNum1++;
            }
        }
    }
}