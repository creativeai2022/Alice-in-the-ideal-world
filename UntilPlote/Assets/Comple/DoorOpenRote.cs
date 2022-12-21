using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class DoorOpenRote : MonoBehaviour
{
    //��]���������p�x
    public float RotationValue;

    //�h�A�ɋ߂����ǂ����̔���
    public bool nearThisDoor;

    //�e�h�A���J���������ۂ̔���
    public bool isOpen1;
    public bool isOpen2;
    public bool isOpen3;
    public bool isOpen4;
    public bool isOpen5;

    //���̃X�N���v�g���A�^�b�`����h�A�I�u�W�F�N�g
    public GameObject ThisDoorObject;

    // �ʉߔ���̃Q�[���I�u�W�F�N�g
    public GameObject DoorGate;

    //�u�J����FE�v�̃E�B���h�E
    public GameObject Window;

    void Start()
    {
    }

    void Update()
    {
        //�h�A�ɋ߂��Ƃ�
        if (nearThisDoor)
        {
            //Debug.Log("�߂�");

            //E�{�^���������ꂽ��
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Debug.Log("�����ꂽ");

                //�J�������Ԃł���Ȃ�
                if (CanYouOpen.canOpen)
                {

                    //�P�ڂ̃����_���h�A
                    if (ThisDoorObject.CompareTag("1"))
                    {

                        //�h�A���J���ĂȂ����
                        if (!isOpen1)
                        {
                            //�h�A���J�������Ƃɂ���
                            isOpen1 = true;

                            //�u�J����FE�v������
                            Window.SetActive(false);

                        }
                    }

                    //�Q�ڂ̃����_���h�A
                    else if (ThisDoorObject.CompareTag("2"))
                    {
                        //�h�A���J���ĂȂ����
                        if (!isOpen2)
                        {
                            //�h�A���J�������Ƃɂ���
                            isOpen2 = true;

                            //�u�J����FE�v������
                            Window.SetActive(false);

                        }
                    }

                    //�R�ڂ̃����_���h�A
                    else if (ThisDoorObject.CompareTag("3"))
                    {
                        //�h�A���J���ĂȂ����
                        if (!isOpen3)
                        {
                            //�h�A���J�������Ƃɂ���
                            isOpen3 = true;

                            //�u�J����FE�v������
                            Window.SetActive(false);

                        }
                    }

                    //�S�ڂ̃����_���h�A
                    else if (ThisDoorObject.CompareTag("4"))
                    {
                        //�h�A���J���ĂȂ����
                        if (!isOpen4)
                        {
                            //�h�A���J�������Ƃɂ���
                            isOpen4 = true;

                            //�u�J����FE�v������
                            Window.SetActive(false);

                        }
                    }

                    //�T�ڂ̃����_���h�A
                    else if (ThisDoorObject.CompareTag("5"))
                    {
                        //�h�A���J���ĂȂ����
                        if (!isOpen5)
                        {
                            //�h�A���J�������Ƃɂ���
                            isOpen5 = true;

                            //�u�J����FE�v������
                            Window.SetActive(false);

                        }
                    }

                    //�R���[�`���̎g�p
                    StartCoroutine("CanThrrow");

                }

                //Debug.Log("�J����");

            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //�P�ڂ̃����_���h�A
        if (ThisDoorObject.CompareTag("1"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen1)
            {
                // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v�̕\��
                    Window.SetActive(true);
                    //Debug.Log("�G�ꂽ");

                    //�h�A�ɋ߂����ǂ�����Bool���X�V��
                    nearThisDoor = true;

                }
            }
        }

        //�Q�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("2"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen2)
            {
                // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v�̕\��
                    Window.SetActive(true);
                    //Debug.Log("�G�ꂽ");

                    //�h�A�ɋ߂����ǂ�����Bool���X�V��
                    nearThisDoor = true;

                }
            }
        }

        //�R�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("3"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen3)
            {
                // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v�̕\��
                    Window.SetActive(true);
                    //Debug.Log("�G�ꂽ");

                    //�h�A�ɋ߂����ǂ�����Bool���X�V��
                    nearThisDoor = true;

                }
            }
        }

        //�S�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("4"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen4)
            {
                // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v�̕\��
                    Window.SetActive(true);
                    //Debug.Log("�G�ꂽ");

                    //�h�A�ɋ߂����ǂ�����Bool���X�V��
                    nearThisDoor = true;

                }
            }
        }

        //�T�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("5"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen5)
            {
                // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v�̕\��
                    Window.SetActive(true);
                    //Debug.Log("�G�ꂽ");

                    //�h�A�ɋ߂����ǂ�����Bool���X�V��
                    nearThisDoor = true;

                }
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        //�P�ڂ̃����_���h�A
        if (ThisDoorObject.CompareTag("1"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen1)
            {
                // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v������
                    Window.SetActive(false);

                    //�h�A�ɋ߂����ǂ�����Bool���X�V
                    nearThisDoor = false;

                }
            }
        }

        //�Q�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("2"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen2)
            {
                // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v������
                    Window.SetActive(false);

                    //�h�A�ɋ߂����ǂ�����Bool���X�V
                    nearThisDoor = false;

                }
            }
        }

        //�R�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("3"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen3)
            {
                // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v������
                    Window.SetActive(false);

                    //�h�A�ɋ߂����ǂ�����Bool���X�V
                    nearThisDoor = false;

                }
            }
        }

        //�S�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("4"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen4)
            {
                // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v������
                    Window.SetActive(false);

                    //�h�A�ɋ߂����ǂ�����Bool���X�V
                    nearThisDoor = false;

                }
            }
        }

        //�T�ڂ̃����_���h�A
        else if (ThisDoorObject.CompareTag("5"))
        {
            //�h�A���J���ĂȂ����
            if (!isOpen5)
            {
                // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
                if (collision.gameObject.CompareTag("Player"))
                {
                    //�u�J����FE�v������
                    Window.SetActive(false);

                    //�h�A�ɋ߂����ǂ�����Bool���X�V
                    nearThisDoor = false;

                }
            }
        }
    }

    //�h�A���J���Ă��班���҂��ăQ�[�g���o���A�i�߂�悤�ɂȂ�
    //���߂̃R���[�`���쐬
    IEnumerator CanThrrow()
    {
        //�h�A��0.5�b�ŊJ����
        transform.DORotate(new Vector3(0, RotationValue, 0), 0.5f);

        yield return new WaitForSeconds(0.5f); //�҂���

        //�ʉ߂ł���悤�ɂ���
        DoorGate.SetActive(true);
    }
}
