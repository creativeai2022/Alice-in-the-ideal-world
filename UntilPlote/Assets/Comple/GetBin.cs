using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBin : MonoBehaviour
{
    public bool nearBin;

    public static bool getBin;


    public GameObject Bin;

    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getBin)
        {
            if (nearBin)
            {
                //E�{�^���������ꂽ��
                if (Input.GetKey(KeyCode.E))
                {
                    //�r������
                    Bin.SetActive(false);
                    Window.SetActive(false);
                    getBin = true;
                }
            }
        }



    }

    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�v���C���[���߂Â��Ă���
        if (other.gameObject.CompareTag("Player"))
        {

            nearBin = true;
            Window.SetActive(true);


        }

    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearBin = false;
            Window.SetActive(false);
        }
    }
}
