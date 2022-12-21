using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenDoorw : MonoBehaviour
{
    public GameObject Window;
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
                if (OnSwich.onSwitch)
                {
                    Destroy(gameObject);
                    Window.SetActive(false);
                    SceneManager.LoadScene("Next");
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトの名前が"Cube"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(true);
            nearThisDoor = true;

        }
    }

    void OnCollisionExit(Collision collision)
    {
        // もし接触から離れた相手オブジェクトの名前が"Plane"ならば
        if (collision.gameObject.name == "Cube")
        {
            Window.SetActive(false);
            nearThisDoor = false;
        }
    }
}
