using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceController4_2 : MonoBehaviour
{
    public Image image;
    private Sprite sprite;
    public GameObject Alice;
    public GameObject WhiteRabbit;
    public GameObject Queen;
    public GameObject Cat;
    public int number=1;
    // Start is called before the first frame update
    void Start()
    {
        number=1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            number++;
            
            if(number== 24||number==56||number==99||number==179||number==103||number==111)//a1
            {
                sprite = Resources.Load<Sprite>("Alice/alice_disappointed");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number== 4||number==21||number==29||number==149||number==196)//a2
            {
                sprite = Resources.Load<Sprite>("Alice/alice_doubt");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            if(number == 0)//a3
            {
                sprite = Resources.Load<Sprite>("Alice/alice_panic");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 8 ||number==22||number==58||number==80)//a4
            {
                sprite = Resources.Load<Sprite>("Alice/alice_sad");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 61)//a5
            {
                sprite = Resources.Load<Sprite>("Alice/alice_shadow");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            
            if(number == 134)//a6
            {
                sprite = Resources.Load<Sprite>("Alice/alice_sleep");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 0)//a7
            {
                sprite = Resources.Load<Sprite>("Alice/alice_smile");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 35 )//a8
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard_smile");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            if(number==15||number==30||number==36||number==37||number==53)//a9
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number ==  85 || number== 170)//a10
            {
                sprite = Resources.Load<Sprite>("Alice/alice_surprised_1");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }


            if(number== 14||number==18||number==32||number==49||number==90||number==203)//a11
            {
                    sprite = Resources.Load<Sprite>("Alice/alice_surprised_2");
                    image = Alice.GetComponent<Image>();
                    image.sprite = sprite;
            }
            

            if(number== 10 )//r3
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 2)//r4
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard2");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 5 )//r1
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_cool");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }
            if(number== 201)//r2
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_disappointed");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 205)//r5
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_surprised");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 0)//q1
            {
                    sprite = Resources.Load<Sprite>("Queen/泣");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 11)//q2
            {
                    sprite = Resources.Load<Sprite>("Queen/笑");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 41)//q3
            {
                    sprite = Resources.Load<Sprite>("Queen/絶望");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 8||number==19||number==23||number==38||number==62)//q4
            {
                    sprite = Resources.Load<Sprite>("Queen/通常");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 3||number==13||number==20||number==25||number==45)//q5
            {
                    sprite = Resources.Load<Sprite>("Queen/怒");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 37||number==82||number==91||number==95)//c1
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_cool");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 5||number==100)//c2
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_disappointed");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 76||number==94)//c3
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_smile");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 9||number==72||number==79||number==84)//c4
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_standard");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 75 )//c5
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_standard2");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 34)//c6
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_surprised");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }






        }
    }
}
