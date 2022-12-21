using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSize : MonoBehaviour
{
    public int charaState;

    public bool big;
    public bool normal;
    public bool small;

    public static bool Big;
    public static bool Normal;
    public static bool Small;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        charaState = BSSize.CharaSizeState;

        big = Big;
        normal = Normal;
        small = Small;

        switch (charaState)
        {
            case 2:
                Big = true;
                Normal = false;
                Small = false;
                break;

            case 1:
                Big = false;
                Normal = true;
                Small = false;
                break;

            case 0:
                Big = false;
                Normal = false;
                Small = true;
                break;
        }


    }
}

