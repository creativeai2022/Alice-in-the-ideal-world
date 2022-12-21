using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    public GameObject fadePanel;

    // Start is called before the first frame update
    void Start()
    {
        fadePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        StartCoroutine("StartGameCoroutine");
    }

    private IEnumerator StartGameCoroutine()
    {
        fadePanel.SetActive(true);
        FadeController.isFadeOut = true;
        yield return new WaitForSeconds(2);

        
        //SceneManager.LoadScene("ScenarioBase");
        SceneManager.LoadScene("Scenario0");
        

        //SceneManager.LoadScene("");
    }

    public void MoveMenu()
    {
        StartCoroutine("MoveMenuCoroutine");
    }

    private IEnumerator MoveMenuCoroutine()
    {
        fadePanel.SetActive(true);
        FadeController.isFadeOut = true;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menuscene");
        OpenMenu.currentScene = SceneManager.GetActiveScene().name;
    }



    public void QuitGame()
    {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
        //  Application.Quit();//ゲームプレイ終了
#endif
    }

}
