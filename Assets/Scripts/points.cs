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
            print('1');
            if (transform.eulerAngles.x < -10 || transform.eulerAngles.x > 10)
            {
                print('2');
                //score.getScore();
                Destroy(gameObject);
            }
            else if (transform.eulerAngles.z < -10 || transform.eulerAngles.z > 10)
            {
                print('3');
                //score.getScore();
                Destroy(gameObject);
            }
        }  
    }
}
