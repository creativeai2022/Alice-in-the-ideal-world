using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyR : MonoBehaviour
{
    //�J�M�ɋ߂���
    public bool nearKey = false;

    //�����Ă錮
    public GameObject KeyR;

    // �����������
    public static bool getKeyR;

    //�E���E�B���h�E
    public GameObject Window;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //�J�M�ɋ߂��Ƃ�
        if (nearKey)
        {
            //E�{�^���������ꂽ��
            if (Input.GetKey(KeyCode.E))
            {
                //�J�M�Ƃ̋߂���Y���
                nearKey = false;

                //�����Ă�J�M���\���ɂ���
                KeyR.SetActive(false);

                //�u�E���FE�v���\��
                Window.SetActive(false);

                //������������Ƃɂ���
                getKeyR = true;
            }
        }
    }


    public void OnCollisionEnter(Collision collision)
    {

        //�v���C���[���߂Â��Ă����Ƃ�
        if (collision.gameObject.tag == "Player")
        {
            //�u�E���FE�v�̕\��
            Window.SetActive(true);

            //�J�M�ɋ߂����Ƃɂ���
            nearKey = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {

        //�v���C���[�����ꂽ�Ƃ���
        if (collision.gameObject.CompareTag("Player"))
        {
            //�u�E���FE�v�̔�\��
            Window.SetActive(false);

            //�J�M�ɋ߂��Ȃ����Ƃɂ���
            nearKey = false;

        }
    }
}
