using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemCustle : MonoBehaviour
{
    //���̃X�N���v�g���A�^�b�`����Ă�Q�[���I�u�W�F�N�g
    [SerializeField]
    private GameObject ThisScripts_AttachedItem;

    //�߂����ǂ���
    private bool isNear_ThisObject;

    //�E���̃|�b�v�A�b�v�E�B���h�E
    [SerializeField]
    private GameObject Get_PopUp_Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isNear_ThisObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(ThisScripts_AttachedItem);
                isNear_ThisObject = false;

                Get_PopUp_Window.SetActive(false);
            }
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isNear_ThisObject = true;

            Get_PopUp_Window.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isNear_ThisObject = false;

            Get_PopUp_Window.SetActive(false);

        }
    }
}
