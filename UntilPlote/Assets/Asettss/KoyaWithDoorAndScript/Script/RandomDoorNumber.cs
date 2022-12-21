using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDoorNumber : MonoBehaviour
{
    //ドアのタグをストリング型で管理するための配列作成
    public string[] DoorNumber = { "1", "2", "3", "4", "5" };

    //どのドアのタグが正しいドアのタグになるかをランダムで決めるためのポインタ作成
    public int randomPointer;

    //決めたドアタグを収納する変数
    public static string doorNumber;


    // Start is called before the first frame update
    void Start()
    {
        //配列の1～5のうちどこを示すかポインタをランダム作成
        randomPointer = Random.Range(0, 5);

        //決めたドアタグを収納する変数に収納
        doorNumber = DoorNumber[randomPointer];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
