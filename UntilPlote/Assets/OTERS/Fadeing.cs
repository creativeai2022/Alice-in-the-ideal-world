using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeing : MonoBehaviour
{

    public CanvasGroup a;//CanvasGroup�^�̕ϐ�a��錾�@���Ƃ�CanvasGroup���A�^�b�`����

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a.alpha = ALp.alpth;//�ϐ�a��alpha�l��ύX
    }
}
