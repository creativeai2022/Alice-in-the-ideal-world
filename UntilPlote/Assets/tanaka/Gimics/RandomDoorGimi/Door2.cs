using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Door2 : MonoBehaviour
{
    public GameObject PlayerFirst;
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
        if (nearThisDoor)
        {
            if (GameManager.getKey)
            {
                if (Input.GetKey(KeyCode.E))
                {

                    if (GameManager.TrueDoorNumber == 2)
                    {
                        SceneManager.LoadScene("Next");
                    }
                    else
                    {
                        PlayerFirst.transform.position = GameManager.FirstPosition;
                    }
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
            Debug.Log("触れた");
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
