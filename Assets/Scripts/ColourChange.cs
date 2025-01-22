using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColourChange : MonoBehaviour
{
    // Start is called before the first frame update
    
    Color colorChange = Color.red;
    Color white;
    SpriteRenderer circleRenderer;


    void Start()
    {
        circleRenderer = GetComponent<SpriteRenderer>();
        white = circleRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        circleRenderer.material.color = colorChange;
    }

}
