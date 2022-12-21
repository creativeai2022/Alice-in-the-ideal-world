using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class otyakai_wave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOLocalMove(new Vector3(-2800f, 0, 0), 10f);
    }
}
