using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningUIController : MonoBehaviour
{
    [SerializeField] GameObject Titlename;
    public Text Titlename1;
    private float red, green, blue, alfa;
    public bool a_flag;
    public bool b_flag;
    public float a_color;
    public float b_color;
    private float titlefadeSpeed = 0.02f;

    void Start()
    {
        a_flag = false;
        b_flag = false;
        a_color = 0;
        b_color = 0;
        Titlename.SetActive(false);
        Titlename1.color = new Color (185, 185, 185, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(LoadText.checkEndtext == true){
            Debug.Log("テキスト終わり");
            FadeController.isFadeOut = true;
		    StartCoroutine ("Title");
            LoadText.checkEndtext = false;
        } 

        if(b_flag){
            Titlename1.color = new Color (185, 185, 185, b_color);      
            b_color += titlefadeSpeed;
            if(b_color >1) {
                b_flag = false;
            }
        }



        if (a_flag) {
            //テキストの透明度を変更する
            Titlename1.color = new Color (185, 185, 185, a_color);
            a_color -=  titlefadeSpeed;
            //透明度が0になったら終了する。
            if (a_color < 0) {
                a_color = 0;
                a_flag = false;
            }
        }
    }

private IEnumerator Title() {  
	        yield return new WaitForSeconds (2.0f); 
            b_flag = true; 
            Titlename.SetActive(true);
            yield return new WaitForSeconds (3.0f);  
            a_flag = true;
            a_color = 1;
	        yield return new WaitForSeconds (1.5f); 
            SceneManager.LoadScene("Scenario1-1");

	}
}
