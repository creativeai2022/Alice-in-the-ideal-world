using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    //���e�i�[�p�I�u�W�F�N�g
    public GameObject Bany;

    //�u���e�FF�v�̃E�B���h�E
    public GameObject Window;

    public GameObject TalkWindow;

    private bool isNear_WhiteRabbit;

    void Start()
    {

    }

    void Update()
    {
        if (isNear_WhiteRabbit)
        {
            //F�L�[�������ꂽ
            if (Input.GetKey(KeyCode.F))
            {
                
                //���e������
                Bany.SetActive(false);

                //�u���e�FF�v������
                Window.SetActive(false);

                TalkWindow.SetActive(true);
                
            }
        }

    }

    //���e�̎��͂̃I�u�W�F�N�g�ɐN�����Ă�����
    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�N�����Ă������̂̃^�O��"Player"�Ȃ�
        if (other.gameObject.CompareTag("Player"))
        {
            //�u���e�FF�v�̕\��
            Window.SetActive(true);

            isNear_WhiteRabbit = true;
        }

    }

    //���e�̎��͂̃I�u�W�F�N�g�����ꂽ��
    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //���ꂽ���̂̃^�O��"Player"�Ȃ�
        if (other.gameObject.CompareTag("Player"))
        {
            //�u���e�FF�v�̔�\��
            Window.SetActive(false);

            isNear_WhiteRabbit = false;
        }

    }
}
