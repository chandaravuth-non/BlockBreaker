using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour {
    [SerializeField]
    int blockBreaker;
    [SerializeField]
    SceneLoader sceneloader;

    public void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }


    public void CountBlock()
    {
        blockBreaker++;
    }

    //count the  blockBox after hit by the ball
    // if the blockBox got all detroyed then go to the next sence
    public void BlockDestroy()
    {
        blockBreaker--;
        if(blockBreaker<=0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
