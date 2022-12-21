using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGetKey : MonoBehaviour
{
    public GameObject Window;
    public bool nearKey;
    public GameObject Key;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearKey)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                GameManager.getKey = true;
                Destroy(Key);
                Window.SetActive(false);
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
            nearKey = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        // もし接触から離れた相手オブジェクトの名前が"Plane"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearKey = false;
        }
    }
}
