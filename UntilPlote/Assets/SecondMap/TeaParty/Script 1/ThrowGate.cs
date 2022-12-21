using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGate : MonoBehaviour
{
    //ゲートに近いかどうかのbool
    public bool nearGate;

    //プレイヤーを格納する
    public GameObject Player;

    //TP先のプレイヤーの位置
    public Vector3 TelepotePosi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //近いとき
        if (nearGate)
        {
            //Eキー押したら
            if(Input.GetKey(KeyCode.E))
            {
                //プレイヤーの位置を移動
                Player.transform.position = TelepotePosi;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //ゲートに近いとする
        nearGate = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        //ゲートに遠いとする
        nearGate = false;
    }
}
