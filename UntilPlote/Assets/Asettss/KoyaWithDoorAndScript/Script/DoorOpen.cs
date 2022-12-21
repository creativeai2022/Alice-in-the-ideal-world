
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorOpen : MonoBehaviour
{

    //�h�A�ɋ߂����ǂ����̔���
    public bool nearThisDoor;

    //�h�A���J���������ۂ̔���
    public bool isOpen;

    //�u�J����FE�v�̃E�B���h�E
    public GameObject Window;

    //�u�����������Ă��܂��v�̃E�B���h�E
    public GameObject RockWindow1;

    //�u�����������Ă��܂��v�̃E�B���h�E
    public GameObject RockWindow2;

    public bool ver = false;

    //�h�A����]����l
    public float RotateValue;

    //�h�A���J���̂ɂ����鉉�o����
    public float RotateTime;



    // Update is called once per frame
    void Update()
    {
        //�h�A�ɋ߂��Ƃ�
        if (nearThisDoor)
        {
            //E�{�^���������ꂽ��
            if (Input.GetKey(KeyCode.E))
            {

                //�h�A���J���ĂȂ�������
                if (!isOpen)
                {
                    ///<>
                    ///�h�A�ɂ���ꂽ�^�O���uopen�v�Ȃ�J���鏈���B
                    ///�h�A�ɂ���ꂽ�^�O���urock�v�Ȃ献�������ĂȂ���ΊJ���Ȃ�����
                    ///<>

                    //�uopen�v�������h�A�Ȃ�
                    if (gameObject.tag == "open")
                    {


                        ///<>
                        ///transform.DORotate(new Vector3(0, 220f, 0), 0.5f);
                        ///��L����130�x��]���A��O�ɊJ���������ɊJ������
                        ///
                        /// transform.DORotate(new Vector3(0, -220f, 0), 0.5f);
                        /// ��L���Ǝ�O��40�x��]�����܂������Ȃ�
                        /// 
                        /// transform.DORotate(new Vector3(0, 10f, 0), 0.5f);
                        /// ��L���ƃh�A�̊J�X��̊p�x���|80�x�ɂȂ��������̃h�A�̊p�x���|90�ł��邱�Ƃ��e�����Ă���̂��H
                        /// 
                        /// transform.DORotate(new Vector3(0, -40f, 0), 0.5f);
                        /// ���z�̉�]�i����130�x�J���Ă����ԁj����������
                        ///<>

                        //�h�A��0.5�b�ŊJ����
                        transform.DORotate(new Vector3(0, RotateValue, 0), RotateTime);

                        //�h�A���J�������Ƃɂ���
                        isOpen = true;

                        //�u�J����FE�v������
                        Window.SetActive(false);
                    }
                    //�urock�v�������h�A�Ȃ�
                    else if (gameObject.tag == "rock")
                    {
                        //�R���[�`���̌Ăяo��
                        StartCoroutine("RockWin");
                    }

                }
            }

        }
    }



    void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
        if (collision.gameObject.CompareTag("Player"))
        {
            //�h�A���J���ĂȂ�������
            if (!isOpen)
            {
                //�u�J����FE�v�̕\��
                Window.SetActive(true);
                Debug.Log("�G�ꂽ");

                //�h�A�ɋ߂����ǂ�����Bool���X�V��
                nearThisDoor = true;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
        if (collision.gameObject.CompareTag("Player"))
        {
            //�h�A���J���ĂȂ�������
            if (!isOpen)
            {
                //�u�J����FE�v������
                Window.SetActive(false);

                //�h�A�ɋ߂����ǂ�����Bool���X�V
                nearThisDoor = false;
            }
        }
    }

    //�R���[�`���̐���
    IEnumerator RockWin()
    {

        // ���߂ɂ���������

        if (ver)
        {
            //�u�������܂��Ă���vver1��\��
            RockWindow1.SetActive(true);
        }
        else
        {
            //�u�������܂��Ă���vver2��\��
            RockWindow2.SetActive(true);
        }

        //�u�J����FE�v���\��
        Window.SetActive(false);

        yield return new WaitForSeconds(1f); //�P�b�҂�

        // ���b��ɂ���������

        //�u�������܂��Ă���v���\��
        RockWindow1.SetActive(false);
        RockWindow2.SetActive(false);

    }
}
