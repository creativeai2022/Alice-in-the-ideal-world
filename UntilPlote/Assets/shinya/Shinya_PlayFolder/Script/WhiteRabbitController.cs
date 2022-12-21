using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteRabbitController : MonoBehaviour
{

    private Animator anim;
    [SerializeField]
    private float animCount = 0f;
    [SerializeField]
    private int motionTime;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("is_Motion",false);
        animCount+=Time.deltaTime;
        if((int)animCount!=0&&(int)animCount%motionTime==0){
            anim.SetBool("is_Motion",true);
        }
        /*
        if(animCount%460==0){
            anim.SetBool("is_Motion",false);
            animCount=0;  
        }
        */
    }
}
