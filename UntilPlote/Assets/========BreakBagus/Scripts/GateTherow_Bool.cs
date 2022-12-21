using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTherow_Bool : MonoBehaviour
{
    //通路に入るためのゲートを通ったか
    public static bool isEnter_Gate_inPaths;

    // インスペクタで確認するための仮変数
    [SerializeField]
    private bool _isEnter_Gate_inPath;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //変更あったら更新
        if (_isEnter_Gate_inPath != isEnter_Gate_inPaths)
        {
            _isEnter_Gate_inPath = isEnter_Gate_inPaths;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //プレイヤーが侵入してきたら
        if (other.gameObject.tag == "Player")
        {
            //そこが通路への入り口なら
            if (this.gameObject.tag == "Entrance")
            {
                //通路にいることにする
                isEnter_Gate_inPaths = !isEnter_Gate_inPaths;
            }
            //それが出口なら
            else if (this.gameObject.tag == "Exit")
            {
                //通路から出たことにする
                isEnter_Gate_inPaths = !isEnter_Gate_inPaths;
            }
        }
    }
}
