using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyAroundL : MonoBehaviour
{
    public bool nearKeyL;

    public static bool getKeyL;


    public GameObject KeyLD;

    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!getKeyL)
        {
            if (nearKeyL)
            {
                //E�{�^���������ꂽ��
                if (Input.GetKey(KeyCode.E))
                {
                    //������
                    KeyLD.SetActive(false);
                    Window.SetActive(false);
                    getKeyL = true;
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
            Window.SetActive(true);
            nearKeyL = true;

        }
    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nearKeyL = false;
        }
        Window.SetActive(false);

    }
}
