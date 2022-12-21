using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigItem : MonoBehaviour
{
    public GameObject bigItem;
    public GameObject Window;
    public GameObject Text;

    public bool nearItem;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearItem)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                GameManager2.isBigItem = true;
                Destroy(bigItem);
                Window.SetActive(false);
                Text.SetActive(true);
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトの名前が"Cube"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            Debug.Log("近づいた");
            nearItem = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        // もし接触から離れた相手オブジェクトの名前が"Plane"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearItem = false;
        }
    }
}
