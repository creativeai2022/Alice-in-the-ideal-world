using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrrm : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponentを用いてAnimatorコンポーネントを取り出す
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //あらかじめ設定していたboolパラメータ「Walk」を取り出す
        float walk = anim.GetFloat("aaaaaa");

        walk += 0.01f;

        anim.SetFloat("aaaaaa", walk); //Walk変数をtrueに設定
    }
}
