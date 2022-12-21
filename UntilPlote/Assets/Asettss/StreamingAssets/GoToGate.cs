using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GoToGate : MonoBehaviour
{

    // ���삷��L�����N�^�[�i�A���X�j
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (DoorAtach.isOpen)
        {
            Debug.Log("�J���Ă�G");

            // �����Փ˂�������I�u�W�F�N�g��Tag��"Player"�Ȃ��
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("�Ԃ����Ă�G");


                //�����A���߂��ɂ���h�A�̃^�O���A�����_���Ɍ��߂�ꂽ�������h�A�^�O�Ɠ������Ȃ��
                if (DoorAtach.isThisDoorTrue)
                {
                    Debug.Log("�h�A������G");

                    //���̃V�[���ֈړ�
                    SceneManager.LoadScene("Forest");
                }
                else
                {

                    Debug.Log("�������Ȃ�G");

                    //�Ⴄ�Ȃ�����Ă����h�A�֌�߂�
                    Player.transform.position = DoorAtach.FirstPosition;

                    //�h�A�̏�Ԃ����Z�b�g
                    DoorAtach.isOpen = false;

                    //�h�A��0.1�b�ŕ߂�
                    transform.DORotate(new Vector3(0, 30f, 0), 0.5f);
                }

            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (DoorAtach.isOpen)
        {
            // �����ڐG���痣�ꂽ����I�u�W�F�N�g��Tag��"Player"�Ȃ��
            if (collision.gameObject.CompareTag("Player"))
            {
        

            }
        }
    }
}
