using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class RotateBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //” ‚Ì‹ß‚­‚©‚Â” ‚ª‹ó‚¢‚Ä‚È‚¢
        if (GetCake.nearBox && !GetCake.isOpen)
        {
            //Eƒ{ƒ^ƒ“‚ð‰Ÿ‚³‚ê‚½‚ç
            if (Input.GetKey(KeyCode.E))
            {
                transform.DORotate(new Vector3(-130f, 100f, 0f), 1f);
            }
        }
    }
}
