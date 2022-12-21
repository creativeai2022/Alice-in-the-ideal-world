using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceController4_1 : MonoBehaviour
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
            
            if(number== 33||number==56||number==148||number==179||number==103||number==111)//a1
            {
                sprite = Resources.Load<Sprite>("Alice/alice_disappointed");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number== 28||number==240||number==265||number==149||number==196)//a2
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

            if(number == 8 ||number==22||number==270||number==276)//a4
            {
                sprite = Resources.Load<Sprite>("Alice/alice_sad");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 275)//a5
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

            if(number == 219 ||number==53)//a8
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard_smile");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            if(number==6||number==13||number==21||number==37||number==53)//a9
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number ==  264 || number== 170)//a10
            {
                sprite = Resources.Load<Sprite>("Alice/alice_surprised_1");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }


            if(number== 2||number==24||number==30||number==40||number==197||number==203)//a11
            {
                    sprite = Resources.Load<Sprite>("Alice/alice_surprised_2");
                    image = Alice.GetComponent<Image>();
                    image.sprite = sprite;
            }
            

            if(number== 207 )//r3
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 211)//r4
            {
                    sprite = Resources.Load<Sprite>("WhiteRabbit/white_rabbit_standard2");
                    image = WhiteRabbit.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 0 )//r1
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

            if(number== 0)//q2
            {
                    sprite = Resources.Load<Sprite>("Queen/笑");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 0)//q3
            {
                    sprite = Resources.Load<Sprite>("Queen/絶望");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 42)//q4
            {
                    sprite = Resources.Load<Sprite>("Queen/通常");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 0)//q5
            {
                    sprite = Resources.Load<Sprite>("Queen/怒");
                    image = Queen.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 84||number==117)//c1
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

            if(number== 0)//c3
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_smile");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 3||number==10||number==35||number==49)//c4
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_standard");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 9 ||number==32||number==41)//c5
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_standard2");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 28)//c6
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_surprised");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }






        }
    }
}
