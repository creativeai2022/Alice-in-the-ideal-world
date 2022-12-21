using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assssd : MonoBehaviour
{
    public GameObject asd;
    public GameObject assd;

    Animator anim1;
    Animator anim2;

    public bool Is;
    public bool On;

    // Start is called before the first frame update
    void Start()
    {
        anim1 = asd.GetComponent<Animator>();
        anim2 = assd.GetComponent<Animator>();

        On = anim1.GetBool("on");
        Is = anim2.GetBool("is");
    }

    // Update is called once per frame
    void Update()
    {

        anim1.SetBool("on", On);
        anim2.SetBool("is", Is);

    }
}
