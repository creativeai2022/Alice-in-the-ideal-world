using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class RotateBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //���̋߂��������󂢂ĂȂ�
        if (GetCake.nearBox && !GetCake.isOpen)
        {
            //E�{�^���������ꂽ��
            if (Input.GetKey(KeyCode.E))
            {
                transform.DORotate(new Vector3(-130f, 100f, 0f), 1f);
            }
        }
    }
}
