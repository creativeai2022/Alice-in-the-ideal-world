using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu4 : MonoBehaviour
{
    /// <summary>
    /// 自動生成用の乱数
    /// </summary>

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset remu4;

    //　テキストファイルから読み込んだデータ
    private string Text4;

    //　改行で分割して配列に入れる
    private string[] SplitText4;

    //　現在表示中テキスト1番号
    private int TextNum4;

    public int remu;
    public int rec;
    public int area;


    /// <summary>
    /// 制御用の変数
    /// </summary>

    private string first;

    // Start is called before the first frame update
    void Start()
    {

        //インスペクタで設定されたやつの読み込み
        Text4 = remu4.text;

        //開業で分ける
        SplitText4 = Text4.Split(char.Parse("\n"));


        TextNum4 = Random.Range(0, SplitText4.Length);

        first = SplitText4[TextNum4];

        remu = int.Parse(first[0].ToString()); // 1
        rec = int.Parse(first[1].ToString()); // 2
        area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 2;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
