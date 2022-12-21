using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tp_roya : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)//オブジェクトに当たったときの関数
    {

        if (collision.gameObject.tag == "Player")
        {//イベントタグのついたゲームオブジェクトに当たった場合
            SceneManager.LoadScene("Castle_Flo1_Roya");

        }
    }

    public void OnCollisionExit(Collision other)//オブジェクトから離れたときの関数
    {
        if (other.gameObject.tag == "Player")////イベントタグのついたゲームオブジェクトに当たった場合
        {
           
        }
    }
}
