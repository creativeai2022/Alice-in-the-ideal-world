using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public static int TrueDoorNumber;
    public static Vector3 FirstPosition;
    public static bool getKey;

    // Start is called before the first frame update
    void Start()
    {
        TrueDoorNumber = Random.Range(1, 6);
        Debug.Log(TrueDoorNumber);

        FirstPosition = Player.transform.position;
        getKey = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
