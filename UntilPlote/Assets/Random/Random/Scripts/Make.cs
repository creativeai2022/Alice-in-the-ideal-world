using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Make : MonoBehaviour
{
    /// <summary>
    /// 自動生成用の乱数
    /// </summary>

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset remu1;
    [SerializeField]
    private TextAsset remu2;
    [SerializeField]
    private TextAsset remu3;
    [SerializeField]
    private TextAsset remu4;
    [SerializeField]
    private TextAsset remu5;

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text remuText1;
    [SerializeField]
    private Text remuText2;
    [SerializeField]
    private Text remuText3;

    //　テキストファイルから読み込んだデータ
    private string Text1;
    private string Text2;
    private string Text3;
    private string Text4;
    private string Text5;


    //　改行で分割して配列に入れる
    private string[] SplitText1;
    private string[] SplitText2;
    private string[] SplitText3;
    private string[] SplitText4;
    private string[] SplitText5;


    //　現在表示中テキスト1番号
    private int TextNum1;
    private int TextNum2;
    private int TextNum3;
    private int TextNum4;
    private int TextNum5;


    /// <summary>
    /// 制御用の変数
    /// </summary>

    private string first;

    /// <summary>
    /// 生成した内容の対応する内容データ
    /// </summary>

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset KoyaArea;
    [SerializeField]
    private TextAsset KoyaRemu;
    [SerializeField]
    private TextAsset WayPatarn;

    //　テキストファイルから読み込んだデータ
    private string Area;
    private string Remu;
    private string Way;

    //　改行で分割して配列に入れる
    private string[] SplitArea;
    private string[] SplitRemu;
    private string[] SplitPatarn;

    /// <summary>
    /// 報酬のobjの格納
    /// </summary>

    //SelectKug格納用の変数
    //private SelectKug selectKug;

    [SerializeField]
    private GameObject[] Remus;

    private int remuNum;

    /// <summary>
    /// 合体したテキスト
    /// </summary>

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text margeText;

    /// <summary>
    /// 報酬個数確認
    /// </summary>

    private int remuCount;

    /*
    // Start is called before the first frame update
    void Start()
    {
        //ヒエラルキーのManagerっていうオブジェクトを探してきて、
        //その中のLifeManagerっていうコンポーネントを取得してきてlifeManagerに代入
        //selectKug = GameObject.Find("RandomManager").GetComponent<SelectKug>();

        //インスペクタで設定されたやつの読み込み
        Text1 = remu1.text;
        Text2 = remu2.text;
        Text3 = remu3.text;
        Text4 = remu4.text;
        Text5 = remu5.text;

        Area = KoyaArea.text;
        Remu = KoyaRemu.text;
        Way = WayPatarn.text;

        //開業で分ける
        SplitText1 = Text1.Split(char.Parse("\n"));
        SplitText2 = Text2.Split(char.Parse("\n"));
        SplitText3 = Text3.Split(char.Parse("\n"));
        SplitText4 = Text4.Split(char.Parse("\n"));
        SplitText5 = Text5.Split(char.Parse("\n"));

        SplitArea = Area.Split(char.Parse("\n"));
        SplitPatarn = Way.Split(char.Parse("\n"));
        SplitRemu = Remu.Split(char.Parse("\n"));

        /*
        while (remuCount <= 5)
        {
            RandomCuest();
            remuCount++;
        }
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*

    public void RandomCuest()
    {
        Debug.Log("a");

        /*
        remuNum = Random.Range(0, 5);


        //remuをいったんすべて非表示に
        for (int i = 0; i < Remus.Length; i++)
        {
            Debug.Log("b");
            Remus[i].SetActive(false);
        }

        

        if (remuCount == 0)
        {
            Remu1();
        }
        else if (remuCount == 1)
        {
            Remu2();
        }
        else if (remuCount == 2)
        {
            Remu3();
        }
        else if (remuCount == 3)
        {
            Remu4();
        }
        else if (remuCount == 4)
        {
            Remu5();
        }
    }

    public void Remu1()
    {
        TextNum1 = Random.Range(0, SplitText1.Length);

        first = SplitText1[TextNum1];

        int remu = int.Parse(first[0].ToString()); // 1
        int rec = int.Parse(first[1].ToString()); // 2
        int area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 3;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

        remuText1.text = SplitArea[area];
        remuText2.text = SplitPatarn[rec];
        remuText3.text = SplitRemu[remu];

        Vector3 posi;

        posi = selectKug.Kugs[area].transform.position;

        Debug.Log(remuCount);
        Debug.Log(posi);

        Remus[remuCount].transform.position = new Vector3(Random.Range(posi.x - 3f, posi.x + 3f), posi.y, Random.Range(posi.x - 3f, posi.x + 3f));

        Remus[remuCount].SetActive(true);

        margeText.text = SplitArea[area] + "で、" + SplitPatarn[rec] + "ことで" + SplitRemu[remu] + "を手に入れる";

    }
    public void Remu2()
    {
        TextNum2 = Random.Range(0, SplitText2.Length);

        first = SplitText1[TextNum2];

        int remu = int.Parse(first[0].ToString()); // 1
        int rec = int.Parse(first[1].ToString()); // 2
        int area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 3;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

        remuText1.text = SplitArea[area];
        remuText2.text = SplitPatarn[rec];
        remuText3.text = SplitRemu[remu];


        Vector3 posi;

        posi = selectKug.Kugs[area].transform.position;

        Debug.Log(remuCount);
        Debug.Log(posi);

        Remus[remuCount].transform.position = new Vector3(Random.Range(posi.x - 3f, posi.x + 3f), posi.y, Random.Range(posi.x - 3f, posi.x + 3f));

        Remus[remuCount].SetActive(true);

        margeText.text = SplitArea[area] + "で、" + SplitPatarn[rec] + "ことで" + SplitRemu[remu] + "を手に入れる";



    }
    public void Remu3()
    {
        TextNum3 = Random.Range(0, SplitText3.Length);

        first = SplitText3[TextNum3];

        int remu = int.Parse(first[0].ToString()); // 1
        int rec = int.Parse(first[1].ToString()); // 2
        int area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 3;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

        remuText1.text = SplitArea[area];
        remuText2.text = SplitPatarn[rec];
        remuText3.text = SplitRemu[remu];

        Vector3 posi;

        posi = selectKug.Kugs[area].transform.position;

        Debug.Log(remuCount);
        Debug.Log(posi);

        Remus[remuCount].transform.position = new Vector3(Random.Range(posi.x - 3f, posi.x + 3f), posi.y, Random.Range(posi.x - 3f, posi.x + 3f));

        Remus[remuCount].SetActive(true);

        margeText.text = SplitArea[area] + "で、" + SplitPatarn[rec] + "ことで" + SplitRemu[remu] + "を手に入れる";



    }
    public void Remu4()
    {
        TextNum4 = Random.Range(0, SplitText4.Length);

        first = SplitText4[TextNum4];

        int remu = int.Parse(first[0].ToString()); // 1
        int rec = int.Parse(first[1].ToString()); // 2
        int area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 3;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

        remuText1.text = SplitArea[area];
        remuText2.text = SplitPatarn[rec];
        remuText3.text = SplitRemu[remu];

        Vector3 posi;

        posi = selectKug.Kugs[area].transform.position;

        Debug.Log(remuCount);
        Debug.Log(posi);

        Remus[remuCount].transform.position = new Vector3(Random.Range(posi.x - 3f, posi.x + 3f), posi.y, Random.Range(posi.x - 3f, posi.x + 3f));
        Remus[remuCount].SetActive(true);

        margeText.text = SplitArea[area] + "で、" + SplitPatarn[rec] + "ことで" + SplitRemu[remu] + "を手に入れる";


    }
    public void Remu5()
    {
        TextNum5 = Random.Range(0, SplitText5.Length);

        first = SplitText5[TextNum5];

        int remu = int.Parse(first[0].ToString()); // 1
        int rec = int.Parse(first[1].ToString()); // 2
        int area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 5;
        rec = (rec) % 3;
        area = (area) % 3;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

        remuText1.text = SplitArea[area];
        remuText2.text = SplitPatarn[rec];
        remuText3.text = SplitRemu[remu];

        Vector3 posi;

        posi = selectKug.Kugs[area].transform.position;

        Debug.Log(remuCount);
        Debug.Log(posi);

        Remus[remuCount].transform.position = new Vector3(Random.Range(posi.x - 3f, posi.x + 3f), posi.y, Random.Range(posi.x - 3f, posi.x + 3f));

        Remus[remuCount].SetActive(true);
        margeText.text = SplitArea[area] + "で、" + SplitPatarn[rec] + "ことで" + SplitRemu[remu] + "を手に入れる";

    }
    */
}
