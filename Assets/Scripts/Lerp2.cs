using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp2 : MonoBehaviour
{
    // Start is called before the first frame update

    [Range(0f, 1f)]
    public float t;

    public AnimationCurve curve;

    public Transform start;
    public Transform end;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 0)
        {
            t += 0.01f;
        }

        if (t > 1)
        {
            t -= 0.01f;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
