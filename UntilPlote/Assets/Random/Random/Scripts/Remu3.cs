using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu3 : MonoBehaviour
{
    /// <summary>
    /// 自動生成用の乱数
    /// </summary>

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset remu3;

    //　テキストファイルから読み込んだデータ
    private string Text3;

    //　改行で分割して配列に入れる
    private string[] SplitText3;

    //　現在表示中テキスト1番号
    private int TextNum3;

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
        Text3 = remu3.text;

        //開業で分ける
        SplitText3 = Text3.Split(char.Parse("\n"));


        TextNum3 = Random.Range(0, SplitText3.Length);

        first = SplitText3[TextNum3];

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
