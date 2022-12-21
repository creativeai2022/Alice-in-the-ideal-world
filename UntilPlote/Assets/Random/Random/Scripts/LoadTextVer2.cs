using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadTextVer2 : MonoBehaviour
{

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text wayText;

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset wayAsset;

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text placeText;

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset placeAsset;

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text remuText;

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset remuAsset;


    //　テキストファイルから読み込んだデータ
    private string wayLoadText;
    //　テキストファイルから読み込んだデータ
    private string placeLoadText;
    //　テキストファイルから読み込んだデータ
    private string remuLoadText;


    //　改行で分割して配列に入れる
    private string[] waySplitText;
    //　改行で分割して配列に入れる
    private string[] placeSplitText;
    //　改行で分割して配列に入れる
    private string[] remuSplitText;


    //　現在表示中テキスト1番号
    private int wayTextNum;
    //　現在表示中テキスト1番号
    private int placeTextNum;
    //　現在表示中テキスト1番号
    private int remuTextNum;

    /// <summary>
    /// 合体させたテキスト表示
    /// </summary>

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text margeText;

    void Start()
    {
        //インスペクタで設定されたやつの読み込み
        wayLoadText = wayAsset.text;
        //インスペクタで設定されたやつの読み込み
        placeLoadText = placeAsset.text;
        //インスペクタで設定されたやつの読み込み
        remuLoadText = remuAsset.text;

        //開業で分ける
        waySplitText = wayLoadText.Split(char.Parse("\n"));
        //開業で分ける
        placeSplitText = placeLoadText.Split(char.Parse("\n"));
        //開業で分ける
        remuSplitText = remuLoadText.Split(char.Parse("\n"));

        //初期分
        //dataText.text = "マウスの左クリックで通常のテキストファイルの読み込み、右クリックでResourcesフォルダ内のテキストファイル読み込みしたテキストが表示されます。";
    }

    void Update()
    {

    }

    public void RandomCuest()
    {
        wayTextNum = Random.Range(0, waySplitText.Length);
        placeTextNum = Random.Range(0, placeSplitText.Length);
        remuTextNum = Random.Range(0, remuSplitText.Length);

        wayText.text = waySplitText[wayTextNum];
        placeText.text = placeSplitText[placeTextNum];
        remuText.text = remuSplitText[remuTextNum];

        margeText.text = placeSplitText[placeTextNum] + waySplitText[wayTextNum] + remuSplitText[remuTextNum];
    }
}
