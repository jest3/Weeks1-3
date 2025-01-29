using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    public AnimationCurve lanternCurve;

    [Range(0f, 1f)]
    public float t;

    
    public Transform pos1;
    public Transform pos2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.Lerp(pos1.position, pos2.position, lanternCurve.Evaluate(t));

    }
}
