using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private bool isCollision;//キャラクターと接触しているかの判定
    int scenario;//シナリオの番号

    public Choice choice;
    public GameObject Choice1;
	public GameObject Choice2;

    public GameObject Window;

    void Start()
    {
        LoadText.checkEndtext = false;
    }

    void Update()
    {
        if(isCollision){//キャラクターと接触時の判定
            if(Input.GetKey(KeyCode.F))
            {
                switch(scenario){
                    case 1:
                        SceneManager.LoadScene("Scenario1-2");
                    break;

                    case 2:
                        SceneManager.LoadScene("Scenario1-3");
                    break;

                    case 3:
                        SceneManager.LoadScene("Scenario4-1");
                    break;

                    case 4:
                        SceneManager.LoadScene("Scenario4-2");
                    break;
                }
            }
        }

		if(LoadText.checkEndtext == true)//会話イベントが終わった場合の処理
		{
            if(SceneManager.GetActiveScene().name == "Scenario0"){
                //SceneManager.LoadScene("Scenario1-1");
                //LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario1-1"){

                SceneManager.LoadScene("koya");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario1-2"){
                demos.deth = true;


                SceneManager.LoadScene("koya");
                
                LoadText.checkEndtext = false;
            }


            if(SceneManager.GetActiveScene().name == "Scenario1-3"){
                SceneManager.LoadScene("Scenario2-1");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario2-1"){
                SceneManager.LoadScene("Scenario2-2");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario2-2"){
                SceneManager.LoadScene("Scenario2-3");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario2-3"){
                SceneManager.LoadScene("Scenario2-4");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario2-4"){
                SceneManager.LoadScene("Scenario2-5");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario2-5"){
                SceneManager.LoadScene("Scenario4-0");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario4-0"){
                SceneManager.LoadScene("Castle-soto");
                LoadText.checkEndtext = false;
            }

            if(SceneManager.GetActiveScene().name == "Scenario4-1"){
                SceneManager.LoadScene("Scenario4-2");
                LoadText.checkEndtext = false;

            }

            Debug.Log("OK");
		}
    }

    public void OnCollisionEnter(Collision collision)//オブジェクトに当たったときの関数
    {

        if(collision.gameObject.tag=="Event"){//イベントタグのついたゲームオブジェクトに当たった場合
            isCollision=true;

            switch(collision.gameObject.name)
            {
                case "Sirousagi"://ゲームオブジェクト名が"Trump"の場合
                    scenario = 1;

                    //collision.gameObject.SetActive(false);
                    //Window.SetActive(false);
                    //collision.gameObject.SetActive(false);
                    //Window.SetActive(false);

                break;

                case "SceneChanger_Koya"://ゲームオブジェクト名が"Trump"の場合
                    scenario = 2;
                break;

                case "Cat"://ゲームオブジェクト名が"Cat"の場合
                    scenario = 3;
                break;

                case "SceneChanger_Catsle"://ゲームオブジェクト名が"Trump"の場合
                    scenario = 4;
                break;

            }
        }
    }

    public void OnCollisionExit(Collision other)//オブジェクトから離れたときの関数
    {
        if(other.gameObject.tag=="Event")////イベントタグのついたゲームオブジェクトに当たった場合
        {
            isCollision=false;
            scenario = 0;
        }
    }

    public void Ending1(){
        switch(choice.ChoiceNum){
            case 1:
                SceneManager.LoadScene("EndingA");
            break;

            case 2:
                SceneManager.LoadScene("EndingB");
            break;

            case 3:
                SceneManager.LoadScene("EndingD");
            break;

        }
    }
    
    public void Ending2(){
        switch(choice.ChoiceNum){
            case 3:
                if(choice.ItemNum <=1){
                    SceneManager.LoadScene("EndingC");
                    Choice1.SetActive(false);
                    Choice2.SetActive(false);
                }
            break;

            case 4:
                if(choice.ItemNum >= 3){
                    SceneManager.LoadScene("EndingE");
                }else if(choice.ItemNum ==2){
                    SceneManager.LoadScene("EndingF");
                }
            break;
        }

    }
}
