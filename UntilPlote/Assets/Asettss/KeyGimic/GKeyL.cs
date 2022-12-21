using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GKeyL : MonoBehaviour
{
    public bool nearKey;
    public GameObject KeyLD;
    public GameObject KeyL;
    public GameObject Window;



    // Start is called before the first frame update
    void Start()
    {
        nearKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nearKey)
        {
            //E�{�^���������ꂽ��
            if (Input.GetKey(KeyCode.E))
            {
                nearKey = false;
                KeyLD.SetActive(false);
                KeyL.SetActive(true);
                Window.SetActive(false);


            }
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        Window.SetActive(true);
        Debug.Log("�G�ꂽ");

        //�v���C���[���߂Â��Ă���
        if (collision.gameObject.CompareTag("Player"))
        {

            nearKey = true;

        }
    }
    public void OnCollisionExit(Collision collision)
    {
        Window.SetActive(false);
        Debug.Log("�G�ꂽ");

        //�v���C���[���߂Â��Ă���
        if (collision.gameObject.CompareTag("Player"))
        {

            nearKey = false;

        }
    }
}
