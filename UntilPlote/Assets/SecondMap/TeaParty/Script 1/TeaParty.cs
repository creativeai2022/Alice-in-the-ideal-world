using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaParty : MonoBehaviour
{
    //ゲートに近いかどうかのbool
    public bool nearTable;

    //Window格納するゲームオブジェクト
    public GameObject Window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //近いとき
        if (nearTable)
        {
            //Eキー押したら
            if(Input.GetKey(KeyCode.E))
            {
                Window.SetActive(true);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //テーブルに近いとする
        nearTable = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        //テーブルに遠いとする
        nearTable = false;
    }
}
