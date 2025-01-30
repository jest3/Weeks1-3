using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DragonHead : MonoBehaviour
{
    //sets speed of dragon movement on the horizontal and vertical axis
    public float moveSpeed = 10;
    //sets the rotation speed of the dragon on the horizontal axis
    public float rotateSpeed = 65;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creats variable for object position
        Vector3 pos = transform.position;
        //changes the dragons position from world space to screen space, so that the dragons position on the screen can be checked in the if statement
        Vector2 dragonPos = Camera.main.WorldToScreenPoint(pos);
        
        //checks if the dragon position reaches the edge of the screen on the x axis
        if (dragonPos.x < 0 || dragonPos.x > Screen.width)
        {
            //sets the move Speed to 0.5
            moveSpeed = 0.9f;
        } 
            //otherwise, when dragon position is not at the edge of the screen, set its speed back to 10
        else
        {
            moveSpeed = 10;
        }

        //moves dragon with arrow keys or WASD on horizontal and vertical axis
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0);
        
        //Rotates dragon with left and right arrow keys, and the A and D keys, on horizontal axis
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
    }
}
