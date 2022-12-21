using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otyakai_scroll : MonoBehaviour
{
    public GameObject prefab;
    private float yPos;

    void Start()
    {
        yPos = Random.Range(-200, 200); // ¦ 1`9‚Ì”ÍˆÍ‚Åƒ‰ƒ“ƒ_ƒ€‚È®”’l‚ª•Ô‚é

        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(400, yPos, 0), Quaternion.identity);
        }
    }
}