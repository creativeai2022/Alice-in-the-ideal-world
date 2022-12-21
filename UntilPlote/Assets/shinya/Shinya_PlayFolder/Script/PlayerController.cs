using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;


public class PlayerController : MonoBehaviour
{
    //歩く速さ
    [SerializeField]
    float speed = 0.05f;

    //回転の速さ
    [SerializeField]
    float smooth = 10f;

    //キャラの状態
    public enum Status
    {
        Stop,
        Move,
        Run,
        Jump,
        Event,
        Pause
    }

    [SerializeField]
    [Tooltip("入手したアイテムのリスト（List<String>）")]
    private List<string> itemList = new List<string>();

    //会話する相手の名前
    [Tooltip("会話相手の名前。Aliceの中のTalkNameをアタッチする")]
    public GameObject talkName;
    //名前を表示するパネル
    [Tooltip("名前を表示するパネル。Aliceの中のNamePanelをアタッチする")]
    public GameObject namePanel;

    //public LoadText myLoad;

    //プレイヤーの状態を示す
    //クラス名+変数名で別のクラスでも使える
    public static Status status;

    //アニメーター
    //キャラクターのアニメーションに関係
    //GetComponent関数でアタッチ
    private Animator anim;

    //物理演算するやつ
    //GetComponent関数でアタッチ
    //事前にオブジェクトにRigidbodyのアタッチ必要
    private Rigidbody rigidbody;

    //地面接触判定
    public bool ground = true;

    //ジャンプモーションの調整用
    private int jumpcount=0;

    //白兎に話しかけた回数
    public int WRabbitTalkCount=0;
    
    //カメラやオブジェクトの回転方向の取得に必要
    private Vector3 target=Vector3.zero;

    //話しかける相手の名前
    //GameObjectではないが、TalkNameをアタッチする
    [Tooltip("テキストの中身を変えるための物。Aliceの中のTalkNameをアタッチする")]
    [SerializeField]private Text talkNameText;

    //現状使用していない
    [SerializeField]private BSSize myBs;

    //ジャンプ力
    [SerializeField] float jumpForce = 250.0f;

    //走るスピード
    [SerializeField] float dashSpeed = 0.25f;

    //歩くスピード
    [SerializeField] float walkSpeed = 0.05f;

    [SerializeField]
    private float waitCount; 

    private bool isCollision=false;


    // Start is called before the first frame update
    void Start()
    {
        /*
        statusをStopに設定
        各オブジェクトのComponentを取得
        */
        status = Status.Stop;
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        talkNameText = talkName.GetComponent<Text>();
        waitCount=0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(status);
        WaitMotion();
        //Statusがイベント以外の時に発生
        if (status == Status.Stop || status == Status.Move || status == Status.Run|| status == Status.Jump)
        {
            //水平回転を作成、Vecter3.up(Vecter3(0,1,0)のこと)の周りに回転を作成
            var horizontalRotation = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector3.up);
            target = horizontalRotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            //targetの平方根を計算
            if (target.magnitude > 0.1)
            {
                //回転方向を取得し、オブジェクトの回転方向に反映する
                Quaternion rotation = Quaternion.LookRotation(target);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);

                //前方に移動する
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }

            //オブジェクトの位置にターゲットの値を足す
            gameObject.transform.position += target * Time.deltaTime;
            //playSE();
            //歩行モーション
            if (target.x != 0 || target.z != 0)
            {
                //Debug.Log("歩くよ");
                status = Status.Move;
                anim.SetBool("is_walking", true);//歩きアニメーション発動
                waitCount=0;//動いている間、待機モーションのカウントを0にする

                //右クリックで走る
                if (Input.GetMouseButton(1)==true&&Input.GetKey(KeyCode.W))
                {
                    //Debug.Log("モーション中");
                    speed = dashSpeed; 
                    anim.SetBool("is_running", true);
                    status = Status.Run;
                    
                    if(Input.GetMouseButtonUp(1)||Input.GetKeyUp(KeyCode.W))//停止モーションに戻る
                    {
                    stop(status);//止まる関数
                    status = Status.Stop;  
                    }
                    
                }
                if(Input.GetMouseButtonUp(1))
                //歩行モーションに戻る
                {
                    status = Status.Move;
                    Debug.Log("ボタン離した");
                    //anim.SetBool("is_walking", true);
                    anim.SetBool("is_running", false);
                    speed = walkSpeed;
                }
            }
            if(target.x == 0 || target.z == 0)//停止モーションに戻る
            {
                stop(status);//止まる関数
                status = Status.Stop;                
            }
        }
    }
    //接触判定
    private void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag){//オブジェクトのタグで分岐
            case "Ground":
            case "Forest":
            if (!ground)//ジャンプ時の動作、地面に触れている時に地面判定がfalseであれば作動
            {
                //ジャンプ時の動作からもとに戻す
                status = Status.Stop;
                ground = true;
                anim.SetBool("is_jumping", false);
                jumpcount=0;
            }
            break;
            case "Event"://会話イベント等のオブジェクトと触れた際に作動
            talkNameText.text="F:話す";
            ShowTalkNameWindow();
            break;
            case "Item"://アイテムの際に発動
             switch(other.gameObject.name){//オブジェクトの名前で分岐
                case "RabbitKey":
                talkNameText.text="F:鍵を取る";
                ShowTalkNameWindow();
                break;
                case "SmallBinFlag":
                if(!GameManager2.isSmallItem){
                    talkNameText.text="F:小瓶を取る";
                    ShowTalkNameWindow();
                }
                break;
                case "BigCakeFlag":
                if(!GameManager2.isBigItem){
                    talkNameText.text="F:ケーキを取る";
                    ShowTalkNameWindow();
                }
                break;
                default:
                talkNameText.text="F:調べる";
                ShowTalkNameWindow();
                break;
            }
            break;
        }
    }

    private void OnCollisionExit(Collision collision) {
		if(collision.gameObject.tag=="Event"||collision.gameObject.tag=="Item")
		{
            HideTalkNameWindow();
            //isCollision=false;
		}
	}

    private void stop(Status status){
        if(status == Status.Move){
            anim.SetBool("is_walking", false);
        }
        if(status == Status.Stop){
            //Debug.Log("止まったよ");
            anim.SetBool("is_running", false);
            anim.SetBool("is_walking", false);
        }
    }

    public void addName(string name){
        itemList.Add(name);
    }

    private void WaitMotion(){//待機モーションを発動させる関数
        waitCount+=Time.deltaTime;//秒数数える
        anim.SetBool("is_waiting", false);
        if((int)waitCount!=0&&(int)waitCount%15==0){//15秒に1回待機モーション
            anim.SetBool("is_waiting", true);
        }
    }

    public void ShowTalkNameWindow(){
        talkName.SetActive(true);
        namePanel.SetActive(true);
    }

    public void HideTalkNameWindow(){
        talkName.SetActive(false);
        namePanel.SetActive(false);
    }
}