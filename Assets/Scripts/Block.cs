using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    Level level;
    int timeHit;
    [SerializeField]
    Sprite[] hitArrayBoxBreaker;


   public  void Start()
    {
        CountBreakBox();

    }

    public void CountBreakBox()
    {
        level = FindObjectOfType<Level>();
        if (tag == "BoxBreaking")
        {
            level.CountBlock();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "BoxBreaking")
        {
            timeHit++;
            int maxHit = hitArrayBoxBreaker.Length + 1;
            if (timeHit == maxHit)
            {
                BlockDestroyer();
            }
            else
            {
                ShowNextArrayBoxBreaker();
            }
            
        }
        
        
    }

    public void ShowNextArrayBoxBreaker()
    {
        int indexBoxBreaker = timeHit - 1;
        GetComponent<SpriteRenderer>().sprite = hitArrayBoxBreaker[indexBoxBreaker];
    }

    public void BlockDestroyer()
    {
        FindObjectOfType<Score>().AddScore();
        Destroy(gameObject);
        level.BlockDestroy();
    }
}
