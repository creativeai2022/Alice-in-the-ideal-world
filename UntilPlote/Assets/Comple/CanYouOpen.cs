using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanYouOpen : MonoBehaviour
{
    //�����_���h�A���J�������Ԃ��ǂ����𔻒肷�邽�߂�bool�ϐ�
    public static bool canOpen;

    //Inspector��Ŋm�F���邽�߂̉��ϐ�
    public bool canopen;

    void Start()
    {

    }

    void Update()
    {
        //���ϐ��̒l�𓯂��ɂ���
        canopen = canOpen;

        //�������Ă邩�������T�C�Y
        if (CharaSize.Small && GetItemManager.getKeyL)
        {
            //�J�������Ԃł���
            canOpen = true;
        }
        else
        {
            //�J�����Ȃ���Ԃł���
            canOpen = false;
        }
    }
}
