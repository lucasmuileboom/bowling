using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public bool left = false;
    public bool right = false;
    public bool leftR = false;
    public bool rightR = false;
    public bool space = false;
  
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            space = false;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            leftR = true;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            leftR = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rightR = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            rightR = false;
        }
    }
}
