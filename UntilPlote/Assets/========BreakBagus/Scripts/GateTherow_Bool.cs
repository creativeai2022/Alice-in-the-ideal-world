using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTherow_Bool : MonoBehaviour
{
    //�ʘH�ɓ��邽�߂̃Q�[�g��ʂ�����
    public static bool isEnter_Gate_inPaths;

    // �C���X�y�N�^�Ŋm�F���邽�߂̉��ϐ�
    [SerializeField]
    private bool _isEnter_Gate_inPath;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�ύX��������X�V
        if (_isEnter_Gate_inPath != isEnter_Gate_inPaths)
        {
            _isEnter_Gate_inPath = isEnter_Gate_inPaths;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //�v���C���[���N�����Ă�����
        if (other.gameObject.tag == "Player")
        {
            //�������ʘH�ւ̓�����Ȃ�
            if (this.gameObject.tag == "Entrance")
            {
                //�ʘH�ɂ��邱�Ƃɂ���
                isEnter_Gate_inPaths = !isEnter_Gate_inPaths;
            }
            //���ꂪ�o���Ȃ�
            else if (this.gameObject.tag == "Exit")
            {
                //�ʘH����o�����Ƃɂ���
                isEnter_Gate_inPaths = !isEnter_Gate_inPaths;
            }
        }
    }
}
