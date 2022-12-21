using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FireSmall : MonoBehaviour
{

    public float scale;
    public GameObject sphere;

    void Start()
    {
        scale = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 2.5f);

        }
    }

}
