using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject Choice1;
    public GameObject Choice2;
    public Text ChoiceText;

    public int ChoiceNum;
    public int ItemNum;

    // Start is called before the first frame update
    void Start()
    {
        ChoiceNum = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Y)){
            ItemNum = 1;
        }
        if(Input.GetKey(KeyCode.U)){
            ItemNum = 2;
        }
        if(Input.GetKey(KeyCode.I)){
            ItemNum = 3;
        }

        if(LoadText.checkEndtext == true){

            if(ChoiceNum==1){
                ChoiceText.text = "選択肢1「現実が辛くても、本当に帰りたいか？」";
            }else if(ChoiceNum==2){
                ChoiceText.text = "選択肢2「チェシャ猫は本当に信じられるか?」";
            }else if(ChoiceNum==3){
                ChoiceText.text = "選択肢3「自分の結論に対して今後後悔はしないと思うか？」";
            }

        }


        //ItemNum = ItemmenuController.isAlice + ItemmenuController.isRabbit + ItemmenuController.isCat + ItemmenuController.isQueen;
    }

    public void Choice2Pick()
    {
        if(ChoiceNum==1)
        {
            Choice1.GetComponentInChildren<Text>().text = "信じられる";
            Choice2.GetComponentInChildren<Text>().text = "疑う余地がある";
        }else if(ChoiceNum==2){
            Choice1.GetComponentInChildren<Text>().text = "絶対後悔しない";
            Choice2.GetComponentInChildren<Text>().text = "後悔するかもしれない";
        }
        ChoiceNum++;
    }
}
