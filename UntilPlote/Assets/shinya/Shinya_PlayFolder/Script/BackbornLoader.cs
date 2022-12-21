using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackbornLoader : MonoBehaviour
{
    //背景史のテキストファイルを読み込む
    [SerializeField]
    private TextAsset aliceBackBorn;
    [SerializeField]
    private TextAsset rabbitBackBorn;
    [SerializeField]
    private TextAsset catBackBorn;
    [SerializeField]
    private TextAsset queenBackBorn;

    //ゲーム中の背景史を表示するテキストオブジェクト
    [SerializeField]
    private Text aliceText;
    [SerializeField]
    private Text rabbitText;
    [SerializeField]
    private Text catText;
    [SerializeField]
    private Text queenText;

    //背景史画面のキャラクターの名前
    [SerializeField]
    private Text aliceNameText;
    [SerializeField]
    private Text rabbitNameText;
    [SerializeField]
    private Text catNameText;
    [SerializeField]
    private Text queenNameText;

    //選択画面のキャラクターの名前
    [SerializeField]
    private Text aliceScrollText;
    [SerializeField]
    private Text rabbitScrollText;
    [SerializeField]
    private Text catScrollText;
    [SerializeField]
    private Text queenScrollText;

    //キャラクター背景史を出すオブジェクト
    //SetActiveの切り替えに使う
    [SerializeField]
    private GameObject aliceTextObject;
    [SerializeField]
    private GameObject rabbitTextObject;
    [SerializeField]
    private GameObject catTextObject;
    [SerializeField]
    private GameObject queenTextObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ItemmenuController.isAlice==1){
            aliceTextObject.SetActive(true);
            aliceText.text=aliceBackBorn.text;
            aliceNameText.text=aliceScrollText.text="アリス";
        }
        if(ItemmenuController.isRabbit==1){
            rabbitTextObject.SetActive(true);
            rabbitText.text=rabbitBackBorn.text;
            rabbitNameText.text=rabbitScrollText.text="白うさぎ";
        }
        if(ItemmenuController.isCat==1){
            catTextObject.SetActive(true);
            catText.text=catBackBorn.text;
            catNameText.text=catScrollText.text="チェシャ猫";
        }
        if(ItemmenuController.isQueen==1){
            queenTextObject.SetActive(true);
            queenText.text=queenBackBorn.text;
            queenNameText.text=queenScrollText.text="ハートの女王";
        }
    }
}
