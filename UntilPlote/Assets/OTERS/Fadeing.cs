using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeing : MonoBehaviour
{

    public CanvasGroup a;//CanvasGroup型の変数aを宣言　あとでCanvasGroupをアタッチする

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a.alpha = ALp.alpth;//変数aのalpha値を変更
    }
}
