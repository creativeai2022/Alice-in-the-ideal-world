using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class PutItem : MonoBehaviour
{
    //SelectKug�i�[�p�̕ϐ�
    private Remu1 remu1;
    private Remu2 remu2;
    private Remu3 remu3;
    private Remu4 remu4;
    private Remu5 remu5;

    //�u���ꏊ�̔z��
    public GameObject[] VerP;
    public GameObject[] VerG;

    //��V�̔z��
    public GameObject[] Remus;

    //�M�~�b�N�p�̕󔠃I�u�W�F�N�g
    public GameObject Box_Room1;
    public GameObject Box_Room3;

    // Start is called before the first frame update
    void Start()
    {
        remu1 = GameObject.Find("Rems").GetComponent<Remu1>();
        remu2 = GameObject.Find("Rems").GetComponent<Remu2>();
        remu3 = GameObject.Find("Rems").GetComponent<Remu3>();
        remu4 = GameObject.Find("Rems").GetComponent<Remu4>();
        remu5 = GameObject.Find("Rems").GetComponent<Remu5>();

        //Debug.Log(Remus);

        for (int i = 0; i < VerG.Length; i++)
        {
            VerG[i].SetActive(false);
        }

        for (int i = 0; i < VerP.Length; i++)
        {
            VerP[i].SetActive(false);
        }


        // Remus1= Remus.OrderBy(i => Guid.NewGurid()).ToArray();
        Shuffle(Remus);
        Shuffle(VerP);
        Shuffle(VerG);

        //Debug.Log(Remus);

        //Debug.Log(verP);
        //Debug.Log(verG);

        PatarnRemu1();
        PatarnRemu2();
        PatarnRemu3();
        PatarnRemu4();
        PatarnRemu5();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PatarnRemu1()
    {
        //rec=1/P rec=2/G
        if (remu1.rec == 1)
        {
            PicUp(0);
        }
        else if (remu1.rec == 0)
        {
            Gimic(0);
        }
    }
    public void PatarnRemu2()
    {
        //rec=1/P rec=2/G
        if (remu2.rec == 1)
        {
            PicUp(1);
        }
        else if (remu2.rec == 0)
        {
            Gimic(1);
        }
    }
    public void PatarnRemu3()
    {
        //rec=1/P rec=2/G
        if (remu3.rec == 1)
        {
            PicUp(2);
        }
        else if (remu3.rec == 0)
        {
            Gimic(2);
        }
    }
    public void PatarnRemu4()
    {
        //rec=1/P rec=2/G
        if (remu4.rec == 1)
        {
            PicUp(3);
        }
        else if (remu4.rec == 0)
        {
            Gimic(3);
        }
    }
    public void PatarnRemu5()
    {
        //rec=1/P rec=2/G
        if (remu5.rec == 1)
        {
            PicUp(4);
        }
        else if (remu5.rec == 0)
        {
            Gimic(4);
        }
    }

    public void PicUp(int remuNum)
    {
        VerP[remuNum].SetActive(true);
        Remus[remuNum].transform.position = VerP[remuNum].transform.position;
        Remus[remuNum].SetActive(true);
    }

    public void Gimic(int remuNum)
    {
        VerG[remuNum].SetActive(true);
        Remus[remuNum].transform.position = VerG[remuNum].transform.position;
        Remus[remuNum].SetActive(true);

        if (VerG[remuNum].gameObject.name == "GPosi2_Box")
        {
            Box_Room1.SetActive(true);
        }
        else if (VerG[remuNum].gameObject.name == "GPosi3_Box")
        {
            Box_Room3.SetActive(true);
        }
    }

    // �����Ƃ��Ď󂯎�����z��̗v�f�ԍ�����ёւ��� 
    void Shuffle(GameObject[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            //�i�����P�j���݂̗v�f��a���Ă���
            GameObject temp = num[i];
            //�i�����Q�j����ւ����������_���ɑI��
            int randomIndex = Random.Range(0, num.Length);
            //�i�����R�j���݂̗v�f�ɏ㏑��
            num[i] = num[randomIndex];
            //�i�����S�j����ւ����ɗa���Ă������v�f��^����
            num[randomIndex] = temp;
        }
    }
}

