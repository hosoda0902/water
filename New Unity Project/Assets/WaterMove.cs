using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMove : MonoBehaviour
{
    bool isUp = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isUp == true)
        {
            transform.localScale += new Vector3(0, 0.01f, 0);
        }
        else
        {
            transform.localScale += new Vector3(0, -0.01f, 0);
        }

        if (transform.localScale.y >= 1.7)
        {
            isUp = false;
        }
        
        if(transform.localScale.y <= 0.5)
        {
            isUp = true;
        }
    }
}
