using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Remu2 : MonoBehaviour
{
    /// <summary>
    /// ���������p�̗���
    /// </summary>

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset remu2;

    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string Text2;

    //�@���s�ŕ������Ĕz��ɓ����
    private string[] SplitText2;

    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int TextNum2;

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
        Text2 = remu2.text;

        //�J�Ƃŕ�����
        SplitText2 = Text2.Split(char.Parse("\n"));


        TextNum2 = Random.Range(0, SplitText2.Length);

        first = SplitText2[TextNum2];

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
