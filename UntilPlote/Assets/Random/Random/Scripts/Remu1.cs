using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu1 : MonoBehaviour
{
    /// <summary>
    /// ���������p�̗���
    /// </summary>

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset remu1;

    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string Text1;

    //�@���s�ŕ������Ĕz��ɓ����
    private string[] SplitText1;

    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int TextNum1;

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
        Text1 = remu1.text;

        //�J�Ƃŕ�����
        SplitText1 = Text1.Split(char.Parse("\n"));


        TextNum1 = Random.Range(0, SplitText1.Length);

        first = SplitText1[TextNum1];

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
