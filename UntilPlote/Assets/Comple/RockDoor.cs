using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDoor : MonoBehaviour
{
    //�h�A�ɋ߂�����bool
    public bool nearRock;

    //�J����邩�ǂ���
    public static bool canOpen;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�J�M�ɋ߂��Ƃ�
        if (nearRock)
        {
            //����R �������Ă���Ƃ�
            if (GetItemManager.getKeyR)
            {
                //�J�����Ƃ���
                canOpen = true;
            }
            else
            {
                //�J����Ȃ��Ƃ���
                canOpen = false;
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�v���C���[���N�����Ă�����
        if (other.gameObject.CompareTag("Player"))
        {
            //�J�M�ɋ߂����Ƃɂ���
            nearRock = true;
        }

    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�v���C���[�������
        if (other.gameObject.CompareTag("Player"))
        {
            //�J�M���牓�����Ƃɂ���
            nearRock = false;
        }

    }
}
