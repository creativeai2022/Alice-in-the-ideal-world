 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

 
public class LoadText : MonoBehaviour {

	public static LoadText instance;
	//　読み込んだテキストを出力するUIテキスト
	[SerializeField]
	private Text dataText;
	//　読む込むテキストが書き込まれている.txtファイル
	[SerializeField]
	private TextAsset textAsset;
	//名前を出力するUIテキスト
	[SerializeField]
	private Text nameText;
	//　テキストファイルから読み込んだデータ
	private string loadText1;
	//　改行で分割して配列に入れる
	private string[] splitText1;
	//セリフの前で分割して配列に入れる
	private string[] splitName;
	//　現在表示中テキスト1番号
	private int textNum1;
	//現在表示中ネーム番号
	private int nameNum;
	private bool cheakCollision=false;

	public GameObject rabbit;
	public GameObject cat;
	public GameObject trumpA;
	public GameObject trumpB;
	public GameObject marchRabbit;
	public GameObject queen;
	public GameObject madHatter;
	private Image image;
	public Image ending;
	private Sprite sprite;
	public GameObject Background;

	public static bool checkEndtext;//会話が終わったかどうかの判定

	const string TARGET1 = "R";
	const string TARGET2 = "E";
	const string TARGET3 = "C";
	const string TARGET4 = "R1";
	const string TARGET5 = "T";
	const string TARGET6 = "T1";
	const string TARGET7 = "X";
	const string TARGET8 = "X1";
	const string TARGET9 = "Y";
	const string TARGET10 = "Y1";
	const string TARGET11 = "A";
	const string TARGET12 = "A1";
	const string TARGET13 = "S";
	const string TARGET14 = "S1";
	const string TARGET15 = "Q";
	const string TARGET16 = "Q1";
	const string TARGET17 = "XY";
	const string TARGET18 = "XY1";
	const string TARGET19 = "Z";
	const string TARGET20 = "M";
	const string TARGET21 = "N";
	const string TARGET22 = "B";
	const string TARGET23 = "B1";
	const string TARGET24 = "BS";
	const string TARGET25 = "SB";
	const string TARGET26 = "D";
	const string TARGET27 = "F";
	const string TARGET28 = "G";
	const string TARGET29 = "H";
	const string TARGET30 = "I";
	const string TARGET31 = "J";

	public Choice choice;

	public GameObject Choice1;
	public GameObject Choice2;
			

	public void Awake()
	{
    	if(instance == null)
    	{
        	instance = this;
    	}
	}

	
	void Start () {

		loadText1 = textAsset.text;
		splitText1 = loadText1.Split(char.Parse("\n"));
		splitName = loadText1.Split(char.Parse("\n"));
		textNum1 = 1;
		nameNum = 0;
		dataText.text = "・・・";
		cheakCollision=true;
		Choice1.SetActive(false);
		Choice2.SetActive(false);
		image = queen.GetComponent<Image>();
	}
 
	void Update () {

		if(Input.GetKey(KeyCode.P)){
			textNum1 = 67;
			nameNum = 66;
		}

		if(cheakCollision)
		{
			//　読み込んだテキストファイルの内容を表示
			if(Input.GetButtonDown("Fire1")) 
			{
				if(splitText1[textNum1] != ""&&nameNum < splitName.Length) {
					
					
					Match match1 = Regex.Match(splitText1[textNum1], @"R", RegexOptions.IgnoreCase);//白兎消える
					Match match4 = Regex.Match(splitText1[textNum1], @"R1", RegexOptions.IgnoreCase);//白兎出現
					Match match5 = Regex.Match(splitText1[textNum1], @"T", RegexOptions.IgnoreCase);//チェシャ猫消える
					Match match6 = Regex.Match(splitText1[textNum1], @"T1", RegexOptions.IgnoreCase);//チェシャ猫出現
					Match match7 = Regex.Match(splitText1[textNum1], @"X", RegexOptions.IgnoreCase);//トランプ兵A消える
					Match match8 = Regex.Match(splitText1[textNum1], @"X1", RegexOptions.IgnoreCase);//トランプ兵A出現
					Match match9 = Regex.Match(splitText1[textNum1], @"Y", RegexOptions.IgnoreCase);//トランプ兵B消える
					Match match10 = Regex.Match(splitText1[textNum1], @"Y1", RegexOptions.IgnoreCase);//トランプ兵B出現
					Match match11 = Regex.Match(splitText1[textNum1], @"A", RegexOptions.IgnoreCase);//アリス消える
					Match match12 = Regex.Match(splitText1[textNum1], @"A1", RegexOptions.IgnoreCase);//アリス出現
					Match match13 = Regex.Match(splitText1[textNum1], @"S", RegexOptions.IgnoreCase);//三月うさぎ消える
					Match match14 = Regex.Match(splitText1[textNum1], @"S1", RegexOptions.IgnoreCase);//三月うさぎ出現
					Match match15 = Regex.Match(splitText1[textNum1], @"Q", RegexOptions.IgnoreCase);//女王消える
					Match match16 = Regex.Match(splitText1[textNum1], @"Q1", RegexOptions.IgnoreCase);//女王出現
					Match match17 = Regex.Match(splitText1[textNum1], @"XY", RegexOptions.IgnoreCase);//トランプ同時消える
					Match match18 = Regex.Match(splitText1[textNum1], @"XY1", RegexOptions.IgnoreCase);//トランプ同時出現
					Match match19 = Regex.Match(splitText1[textNum1], @"Z", RegexOptions.IgnoreCase);//シナリオ4-2の立ち絵特別制御
					Match match20 = Regex.Match(splitText1[textNum1], @"M", RegexOptions.IgnoreCase);//シナリオ4-2の立ち絵特別制御2
					Match match21 = Regex.Match(splitText1[textNum1], @"N", RegexOptions.IgnoreCase);//シナリオ4-2の立ち絵特別制御3
					Match match2 = Regex.Match(splitText1[textNum1], @"E", RegexOptions.IgnoreCase);//シナリオ終わり
					Match match3 = Regex.Match(splitText1[textNum1], @"C", RegexOptions.IgnoreCase);//エンディング選択肢出現
					Match match22 = Regex.Match(splitText1[textNum1], @"B", RegexOptions.IgnoreCase);//帽子屋消える
					Match match23 = Regex.Match(splitText1[textNum1], @"B1", RegexOptions.IgnoreCase);//帽子屋出現
					Match match24 = Regex.Match(splitText1[textNum1], @"BS", RegexOptions.IgnoreCase);//シナリオ2－4立ち絵特別制御
					Match match25 = Regex.Match(splitText1[textNum1], @"SB", RegexOptions.IgnoreCase);//シナリオ2－4立ち絵特別制御2
					Match match26 = Regex.Match(splitText1[textNum1], @"D", RegexOptions.IgnoreCase);//エンディングA背景
					Match match27 = Regex.Match(splitText1[textNum1], @"F", RegexOptions.IgnoreCase);//エンディングB背景
					Match match28 = Regex.Match(splitText1[textNum1], @"G", RegexOptions.IgnoreCase);//エンディングC背景
					Match match29 = Regex.Match(splitText1[textNum1], @"H", RegexOptions.IgnoreCase);//エンディングD背景
					Match match30 = Regex.Match(splitText1[textNum1], @"I", RegexOptions.IgnoreCase);//エンディングE背景
					Match match31 = Regex.Match(splitText1[textNum1], @"J", RegexOptions.IgnoreCase);//エンディングF背景

					if(match1.Success==true){
						rabbit.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET1, "");
						nameText.text = splitName[nameNum];
					}
					else if(match2.Success==true){
						dataText.text = splitText1[textNum1].Replace(TARGET2, "");
						nameText.text = splitName[nameNum].Replace(TARGET2, "");
						checkEndtext = true;
					}
					else{
						dataText.text = splitText1[textNum1];
						nameText.text = splitName[nameNum];
					}

					if(match3.Success==true){
						dataText.text = splitText1[textNum1].Replace(TARGET3, "");
						Choice1.SetActive(true);
						Choice2.SetActive(true);
						checkEndtext = true;
					}

					if(match4.Success==true){
						rabbit.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET4, "");
						nameText.text = splitName[nameNum];
					}

					if(match5.Success==true){
						cat.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET5, "");
						nameText.text = splitName[nameNum];
					}

					if(match6.Success==true){
						cat.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET6, "");
						nameText.text = splitName[nameNum];
					}

					if(match7.Success==true){
						trumpA.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET7, "");
						nameText.text = splitName[nameNum];
					}

					if(match8.Success==true){
						trumpA.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET8, "");
						nameText.text = splitName[nameNum];
					}

					if(match9.Success==true){
						trumpB.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET9, "");
						nameText.text = splitName[nameNum];
					}

					if(match10.Success==true){
						trumpB.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET10, "");
						nameText.text = splitName[nameNum];
					}

					if(match11.Success==true){
						cat.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET11, "");
						nameText.text = splitName[nameNum];
					}

					if(match12.Success==true){
						cat.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET12, "");
						nameText.text = splitName[nameNum];
					}

					if(match13.Success==true){
						marchRabbit.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET13, "");
						nameText.text = splitName[nameNum];
					}

					if(match14.Success==true){
						marchRabbit.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET14, "");
						nameText.text = splitName[nameNum];
					}

					if(match15.Success==true){
						queen.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET15, "");
						nameText.text = splitName[nameNum];
					}

					if(match16.Success==true){
						queen.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET16, "");
						nameText.text = splitName[nameNum];
					}

					if(match17.Success==true){
						trumpA.SetActive(false);
						trumpB.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET17, "");
						nameText.text = splitName[nameNum];
					}

					if(match18.Success==true){
						trumpA.SetActive(true);
						trumpB.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET18, "");
						nameText.text = splitName[nameNum];
					}

					if(match19.Success==true){
						rabbit.SetActive(true);
						cat.SetActive(false);
						queen.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET19, "");
						nameText.text = splitName[nameNum];
					}

					if(match20.Success==true){
						cat.SetActive(false);
						queen.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET20, "");
						nameText.text = splitName[nameNum];
					}

					if(match21.Success==true){
						cat.SetActive(true);
						queen.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET21, "");
						nameText.text = splitName[nameNum];
					}

					if(match22.Success==true){
						madHatter.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET22, "");
						nameText.text = splitName[nameNum];
					}

					if(match23.Success==true){
						madHatter.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET23, "");
						nameText.text = splitName[nameNum];
					}

					if(match24.Success==true){
						madHatter.SetActive(true);
						marchRabbit.SetActive(false);
						dataText.text = splitText1[textNum1].Replace(TARGET24, "");
						nameText.text = splitName[nameNum];
					}

					if(match25.Success==true){
						madHatter.SetActive(false);
						marchRabbit.SetActive(true);
						dataText.text = splitText1[textNum1].Replace(TARGET25, "");
						nameText.text = splitName[nameNum];
					}

					if(match26.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/A_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET26, "");
						nameText.text = splitName[nameNum];
					}

					if(match27.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/B_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET27, "");
						nameText.text = splitName[nameNum];
					}

					if(match28.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/C_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET28, "");
						nameText.text = splitName[nameNum];
					}

					if(match29.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/D_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET29, "");
						nameText.text = splitName[nameNum];
					}

					if(match30.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/E_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET30, "");
						nameText.text = splitName[nameNum];
					}

					if(match31.Success==true){
                		sprite = Resources.Load<Sprite>("Ending/F_end");
                		image = Background.GetComponent<Image>();
                		image.sprite = sprite;
						dataText.text = splitText1[textNum1].Replace(TARGET31, "");
						nameText.text = splitName[nameNum];
					}

					if(queen.activeSelf == true & cat.activeSelf == true){

						image.color = new Color (133.0f/255.0f, 133.0f/255.0f, 133.0f/255.0f, 255.0f/255.0f);
					}else
					{
						image.color = new Color (255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f);
					}
					
					


					if(checkEndtext==false){
						textNum1 = textNum1 + 2;
						nameNum = nameNum + 2;
					}


				
				if(textNum1 > splitText1.Length) 
				{
					textNum1 = 0;
				}
				if(nameNum > splitName.Length)
				{
					nameNum = 0;
				}
			} 
			else 
			{
				dataText.text = "";
				textNum1++;
			}
			//　Resourcesフォルダに配置したテキストファイルの内容を表示
			} 
			else if(Input.GetButtonDown("Fire2"))
			{
			
				if(splitText1[textNum1] != "")
				{
					textNum1=textNum1-2;
					nameNum= nameNum-2;
					dataText.text = splitText1[textNum1];
					nameText.text = splitName[nameNum];
					if(textNum1 >= splitText1.Length)
					{
						textNum1 = 0;
					}
				} 
				else
				{
				dataText.text = "";
				textNum1++;
				}
			}


		}
		

		
	}
}