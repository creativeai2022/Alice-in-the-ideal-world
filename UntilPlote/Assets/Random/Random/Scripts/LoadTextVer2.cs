using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadTextVer2 : MonoBehaviour
{

    //�@�ǂݍ��񂾃e�L�X�g���o�͂���UI�e�L�X�g
    [SerializeField]
    private Text wayText;

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset wayAsset;

    //�@�ǂݍ��񂾃e�L�X�g���o�͂���UI�e�L�X�g
    [SerializeField]
    private Text placeText;

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset placeAsset;

    //�@�ǂݍ��񂾃e�L�X�g���o�͂���UI�e�L�X�g
    [SerializeField]
    private Text remuText;

    //�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
    [SerializeField]
    private TextAsset remuAsset;


    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string wayLoadText;
    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string placeLoadText;
    //�@�e�L�X�g�t�@�C������ǂݍ��񂾃f�[�^
    private string remuLoadText;


    //�@���s�ŕ������Ĕz��ɓ����
    private string[] waySplitText;
    //�@���s�ŕ������Ĕz��ɓ����
    private string[] placeSplitText;
    //�@���s�ŕ������Ĕz��ɓ����
    private string[] remuSplitText;


    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int wayTextNum;
    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int placeTextNum;
    //�@���ݕ\�����e�L�X�g1�ԍ�
    private int remuTextNum;

    /// <summary>
    /// ���̂������e�L�X�g�\��
    /// </summary>

    //�@�ǂݍ��񂾃e�L�X�g���o�͂���UI�e�L�X�g
    [SerializeField]
    private Text margeText;

    void Start()
    {
        //�C���X�y�N�^�Őݒ肳�ꂽ��̓ǂݍ���
        wayLoadText = wayAsset.text;
        //�C���X�y�N�^�Őݒ肳�ꂽ��̓ǂݍ���
        placeLoadText = placeAsset.text;
        //�C���X�y�N�^�Őݒ肳�ꂽ��̓ǂݍ���
        remuLoadText = remuAsset.text;

        //�J�Ƃŕ�����
        waySplitText = wayLoadText.Split(char.Parse("\n"));
        //�J�Ƃŕ�����
        placeSplitText = placeLoadText.Split(char.Parse("\n"));
        //�J�Ƃŕ�����
        remuSplitText = remuLoadText.Split(char.Parse("\n"));

        //������
        //dataText.text = "�}�E�X�̍��N���b�N�Œʏ�̃e�L�X�g�t�@�C���̓ǂݍ��݁A�E�N���b�N��Resources�t�H���_���̃e�L�X�g�t�@�C���ǂݍ��݂����e�L�X�g���\������܂��B";
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
