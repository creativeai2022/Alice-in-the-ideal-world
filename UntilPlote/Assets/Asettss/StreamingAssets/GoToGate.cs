using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GoToGate : MonoBehaviour
{

    // 操作するキャラクター（アリス）
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (DoorAtach.isOpen)
        {
            Debug.Log("開いてるG");

            // もし衝突した相手オブジェクトのTagが"Player"ならば
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("ぶつかってるG");


                //もし、今近くにいるドアのタグが、ランダムに決められた正しいドアタグと等しいならば
                if (DoorAtach.isThisDoorTrue)
                {
                    Debug.Log("ドア正しいG");

                    //次のシーンへ移動
                    SceneManager.LoadScene("Forest");
                }
                else
                {

                    Debug.Log("正しくないG");

                    //違うなら入ってきたドアへ後戻り
                    Player.transform.position = DoorAtach.FirstPosition;

                    //ドアの状態をリセット
                    DoorAtach.isOpen = false;

                    //ドアを0.1秒で閉める
                    transform.DORotate(new Vector3(0, 30f, 0), 0.5f);
                }

            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (DoorAtach.isOpen)
        {
            // もし接触から離れた相手オブジェクトのTagが"Player"ならば
            if (collision.gameObject.CompareTag("Player"))
            {
        

            }
        }
    }
}
