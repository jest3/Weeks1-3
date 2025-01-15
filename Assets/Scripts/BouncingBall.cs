using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BouncingBall : MonoBehaviour
{

    float speedX = 0.01f;
    float speedY = 0.01f;
    Boolean KeyPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 circlePos = transform.position;
        circlePos.x += speedX;
        circlePos.y += speedY;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(circlePos);

        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        if(screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY = speedY * -1;
        }

        // reset ball position when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            KeyPressed = true;
        } 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            KeyPressed = false;
        }
        if(KeyPressed == true)
        {
            circlePos.x = 0;
            circlePos.y = 0;
        }

        transform.position = circlePos;

    }
}
