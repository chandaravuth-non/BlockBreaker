using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

    //paramaters
    float screenWidth = 14.5f;
    float minXPos = 1.5f;
    float maxXPos = 14.5f;

     public void Update()
    {
       float mousePos= Input.mousePosition.x / Screen.width * screenWidth;
        Vector2 baskettPos = new Vector2(transform.position.x, transform.position.y);
        baskettPos.x = Mathf.Clamp(mousePos, minXPos, maxXPos);
        transform.position = baskettPos;
    }



}
