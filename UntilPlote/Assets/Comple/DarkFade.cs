using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI���g���Ƃ��ǉ�

public class DarkFade: MonoBehaviour
{
    [SerializeField] private CanvasGroup a;//CanvasGroup�^�̕ϐ�a��錾�@���Ƃ�CanvasGroup���A�^�b�`����

    void Start()
    {
        a.alpha = 0.5f;//�ϐ�a��alpha�l��ύX
    }
}