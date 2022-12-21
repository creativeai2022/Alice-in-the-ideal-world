using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GKeyR : MonoBehaviour
{
    public bool nearKey;
    public GameObject KeyRD;
    public GameObject KeyR;
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
                KeyRD.SetActive(false);
                KeyR.SetActive(true);
                Window.SetActive(false);


            }
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        Window.SetActive(true);

        //�v���C���[���߂Â��Ă���
        if (collision.gameObject.tag=="Player")
        {

            nearKey = true;

        }
    }

    public void OnCollisionExit(Collision collision)
    {
        Window.SetActive(false);

        //�v���C���[���߂Â��Ă���
        if (collision.gameObject.CompareTag("Player"))
        {

            nearKey = false;

        }
    }
}
