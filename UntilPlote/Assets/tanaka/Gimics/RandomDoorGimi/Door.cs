using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Window;
    public GameObject thisDoor;
    public bool nearThisDoor;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (nearThisDoor)
            {
                Destroy(thisDoor);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトの名前が"Cube"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            Debug.Log("触れた");
            nearThisDoor = true;

        }
    }

    void OnCollisionExit(Collision collision)
    {
        // もし接触から離れた相手オブジェクトの名前が"Plane"ならば
        if (collision.gameObject.name == "Cube")
        {
            nearThisDoor = false;

        }
    }
}
