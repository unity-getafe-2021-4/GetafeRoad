using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    public float scaleSpeed;
    public float range;
    float initialScale;
    float scale;

    private void Awake()
    {
        initialScale = transform.localScale.x;
        scale = initialScale;
    }

    void Update()
    {
        scale += scaleSpeed * Time.deltaTime;
        if (scale > initialScale + range)
        {
            scale = initialScale + range;
            scaleSpeed = -scaleSpeed;
        }
        else if (scale < initialScale)
        {
            scale = initialScale;
            scaleSpeed = -scaleSpeed;
        }
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
