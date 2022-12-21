using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceController1_1 : MonoBehaviour
{
    public Image image;
    private Sprite sprite;
    public GameObject Alice;
    public GameObject WhiteRabbit;
    public int number=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            number++;
            
            if(number== 27)//a1
            {
                sprite = Resources.Load<Sprite>("Alice/alice_disappointed");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number== 7 || number== 17 || number== 40)//a2
            {
                sprite = Resources.Load<Sprite>("Alice/alice_doubt");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            
            if(number==2 ||number==9 ||number==41)//a6
            {
                sprite = Resources.Load<Sprite>("Alice/alice_sleep");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number==25 )//a8
            {
                sprite = Resources.Load<Sprite>("Alice/alice_smile");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            if(number==43||number==15||number==24 )//a9
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }


            if(number== 3 ||number== 13 ||number== 32)//a11
            {
                    sprite = Resources.Load<Sprite>("Alice/alice_surprised_2");
                    image = Alice.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 6 ||number== 12 ||number== 23)//r3
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 8 ||number== 21 ||number== 28||number== 33)//r4
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard2");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 30 )//r1
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_cool");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }
            if(number== 35)//r2
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_disappointed");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

        }
    }
}
