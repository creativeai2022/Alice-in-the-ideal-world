using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class GetCake : MonoBehaviour
{
    public static bool nearBox;

    public static bool isOpen;

    public static bool getCake;


    public GameObject Cake;


    public GameObject Window;
    public GameObject GetWindow;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getCake)
        {

            if (nearBox && !isOpen)
            {
                //E�{�^���������ꂽ��
                if (Input.GetKey(KeyCode.E))
                {
                    StartCoroutine("CakeDelay");

                }
            }
            else if (nearBox && isOpen)
            {
                //E�{�^���������ꂽ��
                if (Input.GetKey(KeyCode.E))
                {
                    //�P�[�L����ɓ����
                    Cake.SetActive(false);
                    GetWindow.SetActive(false);
                    getCake = true;
                }
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (!isOpen)
        {
            Window.SetActive(true);
        }
        else if (isOpen && !getCake)
        {
            GetWindow.SetActive(true);
        }

        //�v���C���[���߂Â��Ă���
        if (other.gameObject.CompareTag("Player"))
        {

            nearBox = true;

        }

    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearBox = false;
            if (!isOpen)
            {
                Window.SetActive(false);
            }
            else
            {
                GetWindow.SetActive(false);
            }

        }
    }

    IEnumerator CakeDelay()
    {

        // ���߂ɂ���������
        //�����J����
        Window.SetActive(false);
        GetWindow.SetActive(true);

        yield return new WaitForSeconds(1); //�҂���

        // ���b��ɂ���������
        isOpen = true;

    }
}
