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
        //箱の近くかつ箱が空いてない
        if (GetCake.nearBox && !GetCake.isOpen)
        {
            //Eボタンを押されたら
            if (Input.GetKey(KeyCode.E))
            {
                transform.DORotate(new Vector3(-130f, 100f, 0f), 1f);
            }
        }
    }
}
