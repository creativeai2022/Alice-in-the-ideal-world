using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSE : MonoBehaviour
{
    public PlayerController myPlayer;

    private AudioSource[] audioSources;
    private AudioSource walkAudio;
    private AudioSource runAudio;
    private int count=0;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSources =GetComponents<AudioSource>();
        walkAudio = GetComponent<AudioSource>();
        runAudio = GetComponent<AudioSource>();

        walkAudio=audioSources[0];
        runAudio=audioSources[1];

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
         if(!myPlayer.ground){
            walkAudio.Stop();
            runAudio.Stop();
        }

        switch (PlayerController.status)
        {
            case PlayerController.Status.Move:
            if(count%30==0)
            {
                Debug.Log("歩く音");
                walkAudio.Play();
            }
            break;
            case PlayerController.Status.Run:
            if(count%20==0)
            {
                Debug.Log("走る音");
                runAudio.Play();
            }
            break;
            default:
            walkAudio.Stop();
            runAudio.Stop();
            break;
        }
    }

    private void OnCollisionEnter(Collision other) {
        switch(other.gameObject.tag){
            case "Ground":
            walkAudio=audioSources[0];
            runAudio=audioSources[1];
            break;
            case "Forest":
            walkAudio=audioSources[1];
            runAudio=audioSources[0];
            break;
        }
    }
}