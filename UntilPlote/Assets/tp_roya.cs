using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tp_roya : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)//�I�u�W�F�N�g�ɓ��������Ƃ��̊֐�
    {

        if (collision.gameObject.tag == "Player")
        {//�C�x���g�^�O�̂����Q�[���I�u�W�F�N�g�ɓ��������ꍇ
            SceneManager.LoadScene("Castle_Flo1_Roya");

        }
    }

    public void OnCollisionExit(Collision other)//�I�u�W�F�N�g���痣�ꂽ�Ƃ��̊֐�
    {
        if (other.gameObject.tag == "Player")////�C�x���g�^�O�̂����Q�[���I�u�W�F�N�g�ɓ��������ꍇ
        {
           
        }
    }
}
