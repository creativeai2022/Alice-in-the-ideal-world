using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrrm : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent��p����Animator�R���|�[�l���g�����o��
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //���炩���ߐݒ肵�Ă���bool�p�����[�^�uWalk�v�����o��
        float walk = anim.GetFloat("aaaaaa");

        walk += 0.01f;

        anim.SetFloat("aaaaaa", walk); //Walk�ϐ���true�ɐݒ�
    }
}
