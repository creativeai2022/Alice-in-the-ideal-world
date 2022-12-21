using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (CharaSize.Big)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
