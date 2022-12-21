using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;



public class OpenClose : MonoBehaviour
{
    //�h�A�ɋ߂����ǂ����̔���
    public bool nearThisDoor;

    //�h�A���J���������ۂ̔���
    public bool isOpen;

    //���J���悤�Ƃ��Ă���h�A�����������ǂ����̔���
    public static bool isThisDoorTrue;

    //�u�J����FE�v�̃E�B���h�E
    public GameObject Window;

    //�h�A���������񂠂镔���ɓ��邽�߂̃h�A�̈ʒu
    public static Vector3 FirstPosition;

    // ������̃h�A��GameObject
    public GameObject EnterDoor;

    // ���삷��L�����N�^�[�i�A���X�j
    public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        //�����Ă���h�A�̈ʒu���擾
        FirstPosition = EnterDoor.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //�h�A�ɋ߂��Ƃ�
        if (nearThisDoor)
        {
            Debug.Log("�߂�");

            //E�{�^���������ꂽ��
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("�����ꂽ");

                //�h�A���J���ĂȂ����
                if (!isOpen)
                {
                    Debug.Log("�J����");

                    //�h�A���J�������Ƃɂ���
                    isOpen = true;

                    //�h�A��0.5�b�ŊJ����
                    transform.DORotate(new Vector3(0,-160f, 0), 0.5f);

                    //�u�J����FE�v������
                    Window.SetActive(false);

                }
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log("�����ꂽ");

                //�h�A���J���Ă��
                if (isOpen)
                {
                    Debug.Log("�J����");

                    //�h�A���J�������Ƃɂ���
                    isOpen = false;

                    //�h�A��0.5�b�ŊJ����
                    transform.DORotate(new Vector3(0, 30f, 0), 0.5f);

                    //�u�J����FE�v������
                    Window.SetActive(false);

                }
            }


        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isOpen)
        {
            // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
            if (collision.gameObject.CompareTag("Player"))
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
        if (!isOpen)
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