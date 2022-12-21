using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    [SerializeField]
    private GameObject thisItem;

    private bool canGet = false;

    [SerializeField]
    private GameObject Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canGet)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                thisItem.SetActive(false);
                Window.SetActive(false);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canGet = true;
            Window.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canGet = false;
            Window.SetActive(false);
        }
    }
}
