using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDoorNumber : MonoBehaviour
{
    //�h�A�̃^�O���X�g�����O�^�ŊǗ����邽�߂̔z��쐬
    public string[] DoorNumber = { "1", "2", "3", "4", "5" };

    //�ǂ̃h�A�̃^�O���������h�A�̃^�O�ɂȂ邩�������_���Ō��߂邽�߂̃|�C���^�쐬
    public int randomPointer;

    //���߂��h�A�^�O�����[����ϐ�
    public static string doorNumber;


    // Start is called before the first frame update
    void Start()
    {
        //�z���1�`5�̂����ǂ����������|�C���^�������_���쐬
        randomPointer = Random.Range(0, 5);

        //���߂��h�A�^�O�����[����ϐ��Ɏ��[
        doorNumber = DoorNumber[randomPointer];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
