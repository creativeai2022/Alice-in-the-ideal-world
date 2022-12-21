using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject ItemPanel;
    public GameObject PicturePanel;
    public GameObject StartPanel;
    public GameObject SettingPanel;
    public GameObject Panel01;
    public GameObject Panel02;
    public GameObject Panel03;
    public GameObject Panel04;
    public GameObject Panel05;

    public void DefaultScreen()//スタートパネルを表示
    {
        StartPanel.SetActive(true);
        ItemPanel.SetActive(false);
        PicturePanel.SetActive(false);
        SettingPanel.SetActive(false);
        Panel02.SetActive(false);
        Panel03.SetActive(false);
        Panel04.SetActive(false);
        Panel05.SetActive(false);
    }

   public void OnPushItemButton()//背景史アイテムのパネルを表示
    {
        ItemPanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    public void OnPushPictureButton()//図鑑のパネルを表示
    {
        PicturePanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    public void OnPushSettingButton()//SE・音量のパネルを表示
    {
        SettingPanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    public void OnPushBackButton()//スタートパネルに戻るボタン
    {
        ItemPanel.SetActive(false);
        StartPanel.SetActive(true);
        PicturePanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void OnPushCharaBackButton()//図鑑画面時のバックボタン
    {
        PicturePanel.SetActive(true);
        Panel01.SetActive(true);
        Panel02.SetActive(false);
        Panel03.SetActive(false);
        Panel04.SetActive(false);
        Panel05.SetActive(false);
    }

    public void OnPushEndButton()//ゲーム終了
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
    #else
        Application.Quit();//ゲームプレイ終了
    #endif       
    }

    public void OnPushChara01()
    {
        Panel01.SetActive(false);
        Panel02.SetActive(true);
    }

    public void OnPushChara02()
    {
        Panel01.SetActive(false);
        Panel03.SetActive(true);
    }

    public void OnPushChara03()
    {
        Panel01.SetActive(false);
        Panel04.SetActive(true);
    }

    public void OnPushChara04()
    {
        Panel01.SetActive(false);
        Panel05.SetActive(true);
    }



    private void Start()
    {
        DefaultScreen();
    }


}