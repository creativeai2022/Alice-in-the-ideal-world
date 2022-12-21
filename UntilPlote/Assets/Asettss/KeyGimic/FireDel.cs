using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FireDel : MonoBehaviour
{
    public static bool isBurning;//’g˜F‚ª”R‚¦‚Ä‚¢‚é‚©‚Ç‚¤‚©‚Ì”»’f
    public bool nearFire;
    public GameObject Fire;
    public GameObject KeyR;

    public GameObject Window;
    private Vector3 SmallSize = new Vector3(0.01f, 0.01f, 0.01f);


    // Start is called before the first frame update
    void Start()
    {
        isBurning = true;
    }

    void Update()
    {
        if (isBurning)
        {
            if (nearFire)
            {
                //Eƒ{ƒ^ƒ“‚ð‰Ÿ‚³‚ê‚½‚ç
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("‰Ÿ‚³‚ê‚½");
                    nearFire = false;
                    Fire.transform.DOScale(new Vector3(0.0f, 0.0f, 0.0f), 2.5f);
                }
            }

            if (Fire.transform.localScale.x < SmallSize.x)
            {
                Debug.Log("Á‚·");
                //’g˜F‚ðÁ‚·
                Fire.SetActive(false);
                isBurning = false;
                Window.SetActive(false);
                KeyR.SetActive(true);

            }
        }
    }



    public void OnTriggerEnter(Collider other)
    //•Ð‘¤‚ÅTriggerŽg‚Á‚Ä‚½‚çOnTriggerEnter
    {
        if (isBurning)
        {
            Window.SetActive(true);

            Debug.Log("‚¢‚¥‚“");

            //ƒvƒŒƒCƒ„[‚ª‹ß‚Ã‚¢‚Ä‚«‚Ä
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("‹ß‚¢");
                //’g˜F‚ª”R‚¦‚Ä‚é‚Æ‚«
                if (isBurning)
                {
                    Debug.Log("”R‚¦‚Ä‚é");
                    nearFire = true;
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    //•Ð‘¤‚ÅTriggerŽg‚Á‚Ä‚½‚çOnTriggerEnter
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("—£‚ê‚½");
            Debug.Log("”R‚¦‚Ä‚é");
            nearFire = false;
            Window.SetActive(false);
        }
    }
}
