using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateDoor : MonoBehaviour
{
    //‰ñ“]Ž²
    [SerializeField]
    private GameObject RotatePosi;


    [SerializeField]
    private GameObject Open_TextWindow;

    [SerializeField]
    private GameObject Hide_BackGroundItem;

    [SerializeField]
    private float RotateValue;

    private bool nearDoor = false;

    private bool isThisDoor_Opened = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isThisDoor_Opened)
        {
            if (nearDoor)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("aa");
                    RotatePosi.transform.DORotate(new Vector3(0, RotateValue, 0), 0.5f);

                    Hide_BackGroundItem.SetActive(true);

                    isThisDoor_Opened = true;
                }
            }
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (!isThisDoor_Opened)
        {
            if (collision.gameObject.tag == "Player")
            {
                nearDoor = true;

                Open_TextWindow.SetActive(true);
            }
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            nearDoor = false;

            Open_TextWindow.SetActive(false);
        }

    }
}
