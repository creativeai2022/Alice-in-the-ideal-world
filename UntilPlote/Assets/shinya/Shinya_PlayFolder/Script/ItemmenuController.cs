using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemmenuController : MonoBehaviour
{
    //アリス・白うさぎ・チェシャ猫・女王のアイテムを拾ったかの変数
    public static int isAlice = 0;
    public static int isRabbit = 0;
    public static int isCat = 0;
    public static int isQueen = 0; 

    [SerializeField]
    private GameObject aliceItem;
    [SerializeField]
    private GameObject rabbitItem;
    [SerializeField]
    private GameObject catItem;
    [SerializeField]
    private GameObject queenItem;

    [SerializeField]
    private GameObject nextAliceItem;
    [SerializeField]
    private GameObject nextRabbitItem;
    [SerializeField]
    private GameObject nextCatItem;
    [SerializeField]
    private GameObject nextQueenItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //デバッグ用コマンド
        if(Input.GetKeyDown(KeyCode.T)){
            isAlice=1;
            isRabbit=1;
            isCat=1;
            isQueen=1;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            isAlice=1;
        }

        if(isAlice==1){
            aliceItem.SetActive(false);
            nextAliceItem.SetActive(true);
        }
        if(isRabbit==1){
            rabbitItem.SetActive(false);
            nextRabbitItem.SetActive(true);
        }
        if(isCat==1){
            catItem.SetActive(false);
            nextCatItem.SetActive(true);
        }
        if(isQueen==1){
            queenItem.SetActive(false);
            nextQueenItem.SetActive(true);
        }
    }
}
