using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpCome : MonoBehaviour
{
    public static int whichPosi = 10;

    [SerializeField]
    private GameObject LeftPosi;
    [SerializeField]
    private GameObject RightPosi;
    [SerializeField]
    private GameObject Player;

    private Vector3 LeftPosi_Value;
    private Vector3 RightPosi_Value;

    public Vector3 DeforutPosi_Value;



    // Start is called before the first frame update
    void Start()
    {
        LeftPosi_Value = LeftPosi.transform.position;
        RightPosi_Value = RightPosi.transform.position;


        if (whichPosi == 0)
        {
            Player.transform.position = new Vector3(LeftPosi_Value.x, 2.0f, LeftPosi_Value.z);
        }
        else if (whichPosi == 1)
        {
            Player.transform.position = new Vector3(RightPosi_Value.x, 2.0f, RightPosi_Value.z);
        }
        else
        {
            Player.transform.position = DeforutPosi_Value;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
