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

                    //コルーチンの呼び出し
                    StartCoroutine("BreakOut");
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                //コルーチンの呼び出し
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

    //Aの後に2秒待ってBをする
    IEnumerator BreakOut()
    {

        // 初めにしたいこと(A)

        yield return new WaitForSeconds(0.5f); //待つ時間

        // 数秒後にしたいこと(B)
        Destroy(Box);
        Window.SetActive(false);

        canBreak = false;
        canGet = true;
    }

    //Aの後に2秒待ってBをする
    IEnumerator GetItem()
    {

        // 初めにしたいこと(A)

        yield return new WaitForSeconds(0.5f); //待つ時間

        // 数秒後にしたいこと(B)
        Destroy(Box);
        Window.SetActive(false);

        canBreak = false;
        canGet = true;
    }
}
