using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{

    public bool isBreak;
    public GameObject Window;
    public bool nearThisDoor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearThisDoor)
        {
            if (Input.GetKey(KeyCode.V))
            {
                Destroy(gameObject);
                Window.SetActive(false);
                isBreak = true;
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
        // もし接触から離れた相手オブジェクトの名前が"Plane"ならばs
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearThisDoor = false;

        }
    }
}
