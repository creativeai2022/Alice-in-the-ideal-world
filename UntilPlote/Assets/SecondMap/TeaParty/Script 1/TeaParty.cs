using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaParty : MonoBehaviour
{
    //�Q�[�g�ɋ߂����ǂ�����bool
    public bool nearTable;

    //Window�i�[����Q�[���I�u�W�F�N�g
    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�߂��Ƃ�
        if (nearTable)
        {
            //E�L�[��������
            if(Input.GetKey(KeyCode.E))
            {
                Window.SetActive(true);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //�e�[�u���ɋ߂��Ƃ���
        nearTable = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        //�e�[�u���ɉ����Ƃ���
        nearTable = false;
    }
}
