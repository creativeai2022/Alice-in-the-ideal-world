using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSwich : MonoBehaviour
{
    public static bool onSwitch = false;
    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"Cube"�Ȃ��
        if (collision.gameObject.name == "FallBlock")
        {
            Window.SetActive(true);
            onSwitch= true;
            Debug.Log("�X�C�b�`�������ꂽ");

        }
    }
}
