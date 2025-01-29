using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DragonHead : MonoBehaviour
{
    //sets speed of dragon movement on the horizontal and vertical axis
    public float moveSpeed = 10f;
    //sets the rotation speed of the dragon on the horizontal axis
    public float rotateSpeed = 65f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            moveSpeed = 0;
        }

        transform.position = pos;

        //moves dragon with arrow keys or WASD on horizontal and vertical axis
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0);
        //Rotates dragon with left and right arrow keys, and the A and D keys, on horizontal axis
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);

}
}
