using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    private GameObject Score;
    score score;
    throwing throwing;

    void Start ()
    {
       
    }	
	void Update ()
    {
        if (Score == null)
        {
            score = GameObject.Find("Score").GetComponent<score>();
        }
        if (throwing == null)
        {
            throwing = GameObject.Find("Ball").GetComponent<throwing>();
        }
        if (throwing.despawn)
        {
            if (transform.rotation.x !=0 || transform.rotation.z != 0)
            {
                //score.getScore();
                Destroy(gameObject);
            }
        }  
    }
}
