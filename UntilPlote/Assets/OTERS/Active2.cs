using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active2 : MonoBehaviour
{
public int n;
    void Start()
    {
        n=0;
    }


    void Update()
    {

        if(Input.GetButtonDown("Fire1")){
            n++;
        }

        if (n==17){
            //ゲームオブジェクト表示→非表示
            this.gameObject.SetActive(false);
        }
    }
}