using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackGame(){
        SceneManager.LoadScene(OpenMenu.currentScene);
    }

    public void BackMob(){
                SceneManager.LoadScene("MobMotion");
    }
}
