using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu5 : MonoBehaviour
{
    /// <summary>
    /// ���������p�̗���
    /// </summary>

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset remu5;

    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string Text5;

    //�@���s�ŕ������Ĕz��ɓ����
    private string[] SplitText5;

    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int TextNum5;

    public int remu;
    public int rec;
    public int area;


    /// <summary>
    /// ����p�̕ϐ�
    /// </summary>

    private string first;

    // Start is called before the first frame update
    void Start()
    {

        //�C���X�y�N�^�Őݒ肳�ꂽ��̓ǂݍ���
        Text5 = remu5.text;

        //�J�Ƃŕ�����
        SplitText5 = Text5.Split(char.Parse("\n"));


        TextNum5 = Random.Range(0, SplitText5.Length);

        first = SplitText5[TextNum5];

        remu = int.Parse(first[0].ToString()); // 1
        rec = int.Parse(first[1].ToString()); // 2
        area = int.Parse(first[2].ToString()); // 3

        remu = (remu) % 6;
        rec = (rec) % 3;
        area = (area) % 4;

        Debug.Log(remu);
        Debug.Log(rec);
        Debug.Log(area);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
