using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDoor : MonoBehaviour
{
    //ドアに近いかのbool
    public bool nearRock;

    //開けれるかどうか
    public static bool canOpen;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //カギに近いとき
        if (nearRock)
        {
            //かぎR を持っているとき
            if (GetItemManager.getKeyR)
            {
                //開けれるとする
                canOpen = true;
            }
            else
            {
                //開けれないとする
                canOpen = false;
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //プレイヤーが侵入してきたら
        if (other.gameObject.CompareTag("Player"))
        {
            //カギに近いことにする
            nearRock = true;
        }

    }

    public void OnTriggerExit(Collider other)
    //片側でTrigger使ってたらOnTriggerEnter
    {
        //プレイヤーが離れて
        if (other.gameObject.CompareTag("Player"))
        {
            //カギから遠いことにする
            nearRock = false;
        }

    }
}
