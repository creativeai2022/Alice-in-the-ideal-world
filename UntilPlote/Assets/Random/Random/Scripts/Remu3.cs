using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu3 : MonoBehaviour
{
    /// <summary>
    /// ���������p�̗���
    /// </summary>

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset remu3;

    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string Text3;

    //�@���s�ŕ������Ĕz��ɓ����
    private string[] SplitText3;

    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int TextNum3;

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
        Text3 = remu3.text;

        //�J�Ƃŕ�����
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
