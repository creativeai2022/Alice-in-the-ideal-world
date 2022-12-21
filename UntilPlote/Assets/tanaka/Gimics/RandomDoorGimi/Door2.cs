using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Door2 : MonoBehaviour
{
    public GameObject PlayerFirst;
    public GameObject Window;
    public GameObject thisDoor;
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
            if (GameManager.getKey)
            {
                if (Input.GetKey(KeyCode.E))
                {

                    if (GameManager.TrueDoorNumber == 2)
                    {
                        SceneManager.LoadScene("Next");
                    }
                    else
                    {
                        PlayerFirst.transform.position = GameManager.FirstPosition;
                    }
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
            Debug.Log("�G�ꂽ");
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
