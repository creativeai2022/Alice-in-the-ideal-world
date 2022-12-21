
using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.1f;
            animator.SetBool("is_walking", true);
        }
        else if(Input.GetKey("down"))
        {
            transform.position -= transform.forward * 0.1f;
            animator.SetBool("is_walking", true);
        }
        else
        {
            animator.SetBool("is_walking", false);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 5f, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -5f, 0);
        }
    }



}
