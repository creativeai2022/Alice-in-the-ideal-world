using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FireDel : MonoBehaviour
{
    public static bool isBurning;//�g�F���R���Ă��邩�ǂ����̔��f
    public bool nearFire;
    public GameObject Fire;
    public GameObject KeyR;

    public GameObject Window;
    private Vector3 SmallSize = new Vector3(0.01f, 0.01f, 0.01f);


    // Start is called before the first frame update
    void Start()
    {
        isBurning = true;
    }

    void Update()
    {
        if (isBurning)
        {
            if (nearFire)
            {
                //E�{�^���������ꂽ��
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("�����ꂽ");
                    nearFire = false;
                    Fire.transform.DOScale(new Vector3(0.0f, 0.0f, 0.0f), 2.5f);
                }
            }

            if (Fire.transform.localScale.x < SmallSize.x)
            {
                Debug.Log("����");
                //�g�F������
                Fire.SetActive(false);
                isBurning = false;
                Window.SetActive(false);
                KeyR.SetActive(true);

            }
        }
    }



    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (isBurning)
        {
            Window.SetActive(true);

            Debug.Log("������");

            //�v���C���[���߂Â��Ă���
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("�߂�");
                //�g�F���R���Ă�Ƃ�
                if (isBurning)
                {
                    Debug.Log("�R���Ă�");
                    nearFire = true;
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("���ꂽ");
            Debug.Log("�R���Ă�");
            nearFire = false;
            Window.SetActive(false);
        }
    }
}
