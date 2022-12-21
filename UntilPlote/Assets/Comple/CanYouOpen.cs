using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanYouOpen : MonoBehaviour
{
    //ランダムドアを開けられる状態かどうかを判定するためのbool変数
    public static bool canOpen;

    //Inspector上で確認するための仮変数
    public bool canopen;

    void Start()
    {

    }

    void Update()
    {
        //仮変数の値を同じにする
        canopen = canOpen;

        //鍵持ってるかつ小さいサイズ
        if (CharaSize.Small && GetItemManager.getKeyL)
        {
            //開けられる状態である
            canOpen = true;
        }
        else
        {
            //開けられない状態である
            canOpen = false;
        }
    }
}
