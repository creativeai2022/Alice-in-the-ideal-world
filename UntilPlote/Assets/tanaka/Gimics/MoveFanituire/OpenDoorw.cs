using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenDoorw : MonoBehaviour
{
    public GameObject Window;
    public bool nearThisDoor;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (nearThisDoor)
            {
                if (OnSwich.onSwitch)
                {
                    Destroy(gameObject);
                    Window.SetActive(false);
                    SceneManager.LoadScene("Next");
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"Cube"�Ȃ��
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            nearThisDoor = true;

        }
    }

    void OnCollisionExit(Collision collision)
    {
        // �����ڐG���痣�ꂽ����I�u�W�F�N�g�̖��O��"Plane"�Ȃ��
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearThisDoor = false;
        }
    }
}
