using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBox : MonoBehaviour
{
    public GameObject Window;
    public bool canBreak = false;
    public GameObject Box;

    public bool canGet = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!canGet)
        {
            if (canBreak)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    //�R���[�`���̌Ăяo��
                    StartCoroutine("BreakOut");
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                //�R���[�`���̌Ăяo��
                StartCoroutine("GetItem");
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Window.SetActive(true);

            canBreak = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Window.SetActive(false);

            canBreak = false;
        }
    }

    //A�̌��2�b�҂���B������
    IEnumerator BreakOut()
    {

        // ���߂ɂ���������(A)

        yield return new WaitForSeconds(0.5f); //�҂���

        // ���b��ɂ���������(B)
        Destroy(Box);
        Window.SetActive(false);

        canBreak = false;
        canGet = true;
    }

    //A�̌��2�b�҂���B������
    IEnumerator GetItem()
    {

        // ���߂ɂ���������(A)

        yield return new WaitForSeconds(0.5f); //�҂���

        // ���b��ɂ���������(B)
        Destroy(Box);
        Window.SetActive(false);

        canBreak = false;
        canGet = true;
    }
}
