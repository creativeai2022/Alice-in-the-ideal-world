using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class DoorGateThrow : MonoBehaviour
{
    //�Q�[�g�ɂ���
    public bool nearGate;

    //���J���悤�Ƃ��Ă���h�A�����������ǂ����̔���
    public static bool isThisDoorTrue;

    //�u�ʂ�FE�v�̃E�B���h�E
    public GameObject Window;

    //�h�A���������񂠂镔���ɓ��邽�߂̃h�A�̈ʒu
    public static Vector3 FirstPosition;

    // ������̃h�A��GameObject
    public GameObject EnterDoor;

    // ���삷��L�����N�^�[�i�A���X�j
    public GameObject Player;

    //CanvasGroup�^�̕ϐ�a��錾�@���Ƃ�CanvasGroup���A�^�b�`����
    public CanvasGroup a;

    // �A���t�@�l�̕ύX
    //FadeIn-FadeOut�̎����̂���
    private float valueAluph = 0f;
    private float value = 0.3f;
    private bool fade = false;

    // Start is called before the first frame update
    void Start()
    {
        //�����Ă���h�A�̈ʒu���擾
        FirstPosition = EnterDoor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[�g�ɓ����Ă��
        if (nearGate)
        {
            //�u�ʂ�FE�v�̕\��
            Window.SetActive(true);

            //E�L�[�������ꂽ��
            if (Input.GetKeyDown(KeyCode.E))
            {
                //FadeIn-FadeOut���n�߂�
                StartCoroutine("Fade");

                //�����A���߂��ɂ���h�A�̃^�O���A�����_���Ɍ��߂�ꂽ�������h�A�^�O�Ɠ������Ȃ��
                if (this.gameObject.CompareTag(RandomDoorNumber.doorNumber))
                {
                    //�������h�A�ł���Ƃ���
                    isThisDoorTrue = true;
                    //Debug.Log("������");

                    //���̃V�[���ֈړ�
                    FadeManager.Instance.LoadScene("Castle_first", 1.0f);


                    //QuitGame();
                }


                else
                {
                    //�������Ȃ��Ƃ���
                    isThisDoorTrue = false;
                    //Debug.Log("�������Ȃ�");

                    //�Ⴄ�Ȃ�����Ă����h�A�֌�߂�
                    Player.transform.position = FirstPosition;

                    //�Q�[�g�ɋ߂����ǂ����̔��胊�Z�b�g
                    nearGate = false;

                    //�u�ʂ�FE�v�̔�\��
                    Window.SetActive(false);
                }
            }
        }
    }


    public void OnTriggerEnter(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�v���C���[���߂Â��Ă�����
        if (other.gameObject.CompareTag("Player"))
        {
            //�Q�[�g�ɋ߂��Ƃ���
            nearGate = true;

            //�u�ʂ�FE�v�̕\��
            Window.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    //�Б���Trigger�g���Ă���OnTriggerEnter
    {
        //�v���C���[�����ꂽ��
        if (other.gameObject.CompareTag("Player"))
        {
            //�Q�[�g�ɋ߂��Ȃ��Ƃ���
            nearGate = false;

            //�u�ʂ�FE�v�̔�\��
            Window.SetActive(false);
        }
    }

    IEnumerator Fade1()
    {
        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX

        yield return new WaitForSeconds(0.1f); //�҂���

        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX
    }

    IEnumerator Fade2()
    {
        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX

        yield return new WaitForSeconds(0.1f); //�҂���

        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX
    }

    IEnumerator Fade3()
    {
        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX

        yield return new WaitForSeconds(0.1f); //�҂���

        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX
    }

    IEnumerator Fade4()
    {
        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX

        yield return new WaitForSeconds(0.1f); //�҂���

        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX
    }

    IEnumerator Fade5()
    {
        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX

        yield return new WaitForSeconds(0.1f); //�҂���

        valueAluph += value;
        a.alpha = valueAluph;//�ϐ�a��alpha�l��ύX
    }

    IEnumerator Fade()
    {
        //�Â�����
        StartCoroutine("Fade1");
        StartCoroutine("Fade2");
        StartCoroutine("Fade3");
        StartCoroutine("Fade4");
        StartCoroutine("Fade5");


        yield return new WaitForSeconds(0.1f); //�҂���

        //�ω��l���t�]������
        value = -1f * value;

        //���邭����
        StartCoroutine("Fade1");
        StartCoroutine("Fade2");
        StartCoroutine("Fade3");
        StartCoroutine("Fade4");
        StartCoroutine("Fade5");
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
        Application.Quit();//�Q�[���v���C�I��
#endif
    }


}
