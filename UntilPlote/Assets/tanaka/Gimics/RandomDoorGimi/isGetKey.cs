using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGetKey : MonoBehaviour
{
    public GameObject Window;
    public bool nearKey;
    public GameObject Key;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearKey)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                GameManager.getKey = true;
                Destroy(Key);
                Window.SetActive(false);
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"Cube"�Ȃ��
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            Debug.Log("�߂Â���");
            nearKey = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        // �����ڐG���痣�ꂽ����I�u�W�F�N�g�̖��O��"Plane"�Ȃ��
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearKey = false;
        }
    }
}
