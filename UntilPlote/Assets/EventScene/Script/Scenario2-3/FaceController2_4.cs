using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceController2_4 : MonoBehaviour
{
    public Image image;
    private Sprite sprite;
    public GameObject Alice;
    public GameObject WhiteRabbit;
    public GameObject Queen;
    public GameObject Cat;
    public int number=119;
    // Start is called before the first frame update
    void Start()
    {
        number=119;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            number++;
            
            if(number== 120||number==132||number==148||number==179||number==103||number==111)//a1
            {
                sprite = Resources.Load<Sprite>("Alice/alice_disappointed");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number== 128||number==133||number==144||number==149||number==196)//a2
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

            if(number == 157 ||number==160||number==191||number==200)//a4
            {
                sprite = Resources.Load<Sprite>("Alice/alice_sad");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number == 10)//a5
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

            if(number == 135 ||number==53)//a8
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard_smile");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }
            if(number==121||number==158||number==161||number==213)//a9
            {
                sprite = Resources.Load<Sprite>("Alice/alice_standard");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }

            if(number ==  126 || number== 170)//a10
            {
                sprite = Resources.Load<Sprite>("Alice/alice_surprised_1");
                image = Alice.GetComponent<Image>();
                image.sprite = sprite;
            }


            if(number== 138||number==156||number==166||number==193||number==197||number==203)//a11
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

            if(number== 9)//q2
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

            if(number== 2)//q4
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

            if(number== 66||number==100)//c2
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

            if(number== 180||number==72||number==99||number==101)//c4
            {
                    sprite = Resources.Load<Sprite>("Cat/cheshirecat_standard");
                    image = Cat.GetComponent<Image>();
                    image.sprite = sprite;
            }

            if(number== 70 ||number==97||number==48)//c5
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
