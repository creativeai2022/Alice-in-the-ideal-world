using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveShelves : MonoBehaviour
{
    //ˆÚ“®Ž²
    [SerializeField]
    private GameObject MovePosi;

    [SerializeField]
    private GameObject Open_TextWindow;

    [SerializeField]
    private float MoveValue;

    private bool nearShelves = false;

    private bool isThisShelves_Opened = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isThisShelves_Opened)
        {
            if (nearShelves)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("aa");
                    MovePosi.transform.DOLocalMove(new Vector3(3.8f, 0.1f, 3.6f), 0.5f);

                    isThisShelves_Opened = true;
                }
            }
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            nearShelves = true;

            Open_TextWindow.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            nearShelves = false;

            Open_TextWindow.SetActive(false);
        }
    }
}
