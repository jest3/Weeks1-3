using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Lantern : MonoBehaviour
{
    public AnimationCurve lanternCurve;

    //sets range of animation curve
    [Range(0, 2)]
    //represents total time
    public float t;

    //allows the lantern to have a set starting position and an ending position while lerping
    public Transform pos1;
    public Transform pos2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //total time in seconds increases every frame
        t += Time.deltaTime;

        //if the animation curve reaches its end (2 seonds), reset to 0 to start from beginning again, loops the animation curve
        if (t > 2)
        {
            t = 0;
        }

        //transforms position of the lantern to move from the set position 1 to position 2
        transform.position = Vector2.Lerp(pos1.position, pos2.position, lanternCurve.Evaluate(t));

    }
}
