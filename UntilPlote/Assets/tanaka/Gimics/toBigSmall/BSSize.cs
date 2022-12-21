using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSSize : MonoBehaviour
{
    public static int State;
    public static int CharaSizeState;

    public float toBigScaleY;
    public float toBigScaleXZ;
    public float toSmallScaleY;
    public float toSmallScaleXZ;

    public Vector3 NormalSize;

    public static CharaSize Size = CharaSize.Normal;

    [SerializeField]
    private float nowPosi_Player_X;

    public static bool isPlayer_inPaths;

    [SerializeField]
    private bool _isPlayer_inPaths;


    public bool changing;

    private GameObject lookPos;
    void Start()
    {
        changing = false;

        //�ŏ��̃T�C�Y��ۑ�
        NormalSize = GetComponent<Transform>().localScale;
        //Debug.Log(NormalSize);
        //lookPos= Gameobject.find("LookPos");

    }

    public enum CharaSize
    {
        //�L��������肤���Ԃ��
        Small,
        Normal,
        Big
    }

    //�ŏ��͕��ʃT�C�Y������Normal��


    // Update is called once per frame
    void Update()
    {
        nowPosi_Player_X = this.gameObject.transform.position.x;

        //path
        if (nowPosi_Player_X > -19f && nowPosi_Player_X < 0.6f)
        {
            isPlayer_inPaths = true;
        }//path
        else if ((nowPosi_Player_X > -39.0f && nowPosi_Player_X < -25.0f))
        {
            isPlayer_inPaths = true;
        }
        //room
        else
        {
            isPlayer_inPaths = false;
        }

        _isPlayer_inPaths = isPlayer_inPaths;

        switch (Size)
        {
            case CharaSize.Small:
                CharaSizeState = 0;
                break;
            case CharaSize.Normal:
                CharaSizeState = 1;
                break;
            case CharaSize.Big:
                CharaSizeState = 2;
                break;
        }

        if (!isPlayer_inPaths)
        {
            //toBig
            if (Input.GetKey(KeyCode.R))
            {//B�����ꂽ�Ƃ�
                if (GetCake.getCake)
                {//�傫���Ȃ�A�C�e�����擾�ς�de
                    if (!changing)
                    {//�ω����łȂ��Ȃ�
                        if (!CantBig.cantBig)
                        {
                            if (Size == CharaSize.Big)
                            {
                                //�ő�ő傫���Ȃ�Ȃ����牽�����Ȃ�
                            }
                            else if (Size == CharaSize.Normal)
                            {
                                //���ʃT�C�Y������Big�ɂ���
                                StartCoroutine(ChangeBig());
                                Size = CharaSize.Big;
                            }
                            else if (Size == CharaSize.Small)
                            {
                                //�ŏ������畁�ʃT�C�Y�ɂ���
                                StartCoroutine(ChangeNormal());
                                Size = CharaSize.Normal;
                            }
                        }
                    }
                }
            }

            //toMini
            if (Input.GetKey(KeyCode.T))
            {
                if (GetBin.getBin)
                {
                    if (!changing)
                    {//�ω����łȂ��Ȃ�
                        if (Size == CharaSize.Small)
                        {
                            //�ŏ��ŏ������Ȃ�Ȃ����牽�����Ȃ�
                        }
                        else if (Size == CharaSize.Normal)
                        {
                            //���ʃT�C�Y������Small�ɂ���
                            StartCoroutine(ChangeSmall());
                            Size = CharaSize.Small;
                        }
                        else if (Size == CharaSize.Big)
                        {
                            //�ő傾���畁�ʃT�C�Y�ɂ���
                            StartCoroutine(ChangeNormal());
                            Size = CharaSize.Normal;
                        }
                    }
                }
            }
        }
    }


    private IEnumerator ChangeBig()
    {
        // �����[�h�̃A�j���[�V�����J�n etc...
        // �������g�̑傫����ς���
        GetComponent<Transform>().localScale = new Vector3(NormalSize.x + toBigScaleXZ, NormalSize.y + toBigScaleY, NormalSize.z + toBigScaleXZ);
        changing = true;
        //lookPos.gameobject.transform.position.y=1.2;

        // �Q�b�ҋ@
        yield return new WaitForSeconds(0.5f);

        Debug.Log("�����[�h����");
        changing = false;
    }

    private IEnumerator ChangeNormal()
    {
        // �����[�h�̃A�j���[�V�����J�n etc...
        // �������g�̑傫����ς���
        GetComponent<Transform>().localScale = new Vector3(NormalSize.x, NormalSize.y, NormalSize.z);
        changing = true;
        //lookPos.transform.position.y=0.8;
        // �Q�b�ҋ@
        yield return new WaitForSeconds(0.5f);

        Debug.Log("�����[�h����");
        changing = false;
    }

    private IEnumerator ChangeSmall()
    {
        // �����[�h�̃A�j���[�V�����J�n etc...
        // �������g�̑傫����ς���
        GetComponent<Transform>().localScale = new Vector3(NormalSize.x - toSmallScaleXZ, NormalSize.y - toSmallScaleY, NormalSize.z - toSmallScaleXZ);
        changing = true;
        //lookPos.transform.position.y=0.4;
        // �Q�b�ҋ@
        yield return new WaitForSeconds(0.5f);

        Debug.Log("�����[�h����");
        changing = false;
    }
}

