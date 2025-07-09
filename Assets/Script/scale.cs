using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    float scaled = 1f;
    float scaleSpeed = 0.001f;
    bool isScalingUp = true; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScalingUp)
        {
            scaled += scaleSpeed;
            if (scaled >= 1.2f) isScalingUp = false;
        }
        else
        {
            scaled -= scaleSpeed;
            if(scaled <= 0.2f) isScalingUp=true;
        }
        transform.localScale = new Vector3 (scaled, scaled, scaled);    

        
    }
}
