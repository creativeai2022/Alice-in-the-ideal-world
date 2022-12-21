using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGate : MonoBehaviour
{
    //�Q�[�g�ɋ߂����ǂ�����bool
    public bool nearGate;

    //�v���C���[���i�[����
    public GameObject Player;

    //TP��̃v���C���[�̈ʒu
    public Vector3 TelepotePosi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�߂��Ƃ�
        if (nearGate)
        {
            //E�L�[��������
            if(Input.GetKey(KeyCode.E))
            {
                //�v���C���[�̈ʒu���ړ�
                Player.transform.position = TelepotePosi;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //�Q�[�g�ɋ߂��Ƃ���
        nearGate = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        //�Q�[�g�ɉ����Ƃ���
        nearGate = false;
    }
}
