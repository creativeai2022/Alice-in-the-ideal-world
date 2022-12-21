using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{

    public bool isBreak;
    public GameObject Window;
    public bool nearThisDoor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearThisDoor)
        {
            if (Input.GetKey(KeyCode.V))
            {
                Destroy(gameObject);
                Window.SetActive(false);
                isBreak = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"Cube"�Ȃ��
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            Debug.Log("�G�ꂽ");
            nearThisDoor = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        // �����ڐG���痣�ꂽ����I�u�W�F�N�g�̖��O��"Plane"�Ȃ��s
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearThisDoor = false;

        }
    }
}
