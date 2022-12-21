using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemManager : MonoBehaviour
{

    public static bool getKeyR;
    public static bool getKeyL;
    public static bool getBin;
    public static bool getCake;

    public bool getR;
    public bool getL;
    public bool getbin;
    public bool getcake;

    public GameObject RockDoor;
    public GameObject ToBigWindow;
    public GameObject ToSmallWindow;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        getL = getKeyL;
        getR = getKeyR;
        getcake = getCake;
        getbin = getBin;

        //鍵Rを取ったら
        if (GetKeyR.getKeyR)
        {
            getKeyR = true;
            RockDoor.tag = "open";
        }

        //鍵Lを取ったら
        if (GeyAroundL.getKeyL)
        {
            getKeyL = true;
        }

        //通路にいるなら表示しない
        if (BSSize.isPlayer_inPaths)
        {
            ToBigWindow.SetActive(false);
            ToSmallWindow.SetActive(false);
        }
        else
        {
            //小さくなる薬（ビン）を取ったら
            if (GetBin.getBin)
            {
                getBin = true;
                ToSmallWindow.SetActive(true);
            }

            //大きくなる薬（ケーキ）を取ったら
            if (GetCake.getCake)
            {
                getCake = true;
                ToBigWindow.SetActive(true);

                if (CantBig.cantBig)
                {
                    ToBigWindow.SetActive(false);
                }
            }
        }

    }
}
