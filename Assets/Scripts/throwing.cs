using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class throwing : MonoBehaviour
{
    [SerializeField] private GameObject aim;
    [SerializeField] private Text throwingPowerT;
    private input input;

    private Rigidbody _rigidbody;
    private Vector3 ballP;//
    private int throwingPower = 2000;//
    private float rotation = 0;
    private float timeLeft;//g
    private float StartTime = 10;//
    private bool Throwing = false;//
    private bool timer = false;//
    private bool Throwingcheck = false;//
    private int turncounter = 0;//
    private int Throwcounter = 0;//
    public bool despawn = false;//


    void Start ()
    {
        ballP = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        _rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<input>();
        throwingPowerT.text = throwingPower.ToString();
    }
    void Update()
    {
        if (timer)//reset na gooi
        {
            if (timeLeft < 0)
            {
                throwingPower = 2000;
                throwingPowerT.text = throwingPower.ToString();
                timer = false;
                Throwing = false;
                despawn = true;
                Throwcounter++;
                transform.position = ballP;
                rotation = 0;
                _rigidbody.velocity = Vector3.zero;
                _rigidbody.angularVelocity = Vector3.zero;
                transform.rotation = Quaternion.Euler(0, 0, 0);                
                print("throw over");
                if (Throwcounter == 2)
                {
                    Throwcounter = 0;
                    turncounter++;
                    //end of turn
                    if (turncounter == 10)
                    {
                        turncounter++;
                        //game done
                    }
                }
            }
        timeLeft -= Time.deltaTime;
        }       
        aim.transform.position = new Vector3(transform.position.x, aim.transform.position.y, aim.transform.position.z);
    }
    void FixedUpdate()//aim
    {
        if (!Throwing)
        {
            if (input.left && transform.position.x > -1.3)//links
            {
                transform.Translate(Vector3.left * Time.deltaTime);               
            }
            if (input.right && transform.position.x < 1.3)//rechts 
            {
                transform.Translate(Vector3.right * Time.deltaTime);         
            }
            if (input.leftR && rotation > -45)//rotation links
            {
                rotation--;           
                aim.transform.rotation = Quaternion.Euler(0, rotation, 0);
            }
            if (input.rightR && rotation < 45)//rotation rechts
            {
                rotation++;
                aim.transform.rotation = Quaternion.Euler(0, rotation, 0);
            }
            if (input.space && throwingPower < 6000)//power
            {
                throwingPower = throwingPower + 25;
                print(throwingPower);
                throwingPowerT.text = throwingPower.ToString();
                Throwingcheck = true;
            }
            if (!input.space)//throw
            {
                Throw(); 
            }
        }
    }
    public void Throw()//throw
    {       
        if (!Throwing && Throwingcheck)
        {            
            timeLeft = StartTime;
            despawn = false;
            timer = true;            
            Throwing = true;
            Throwingcheck = false;
            transform.rotation = Quaternion.Euler(0, rotation, 0);
            _rigidbody.AddForce(transform.forward * throwingPower);
        }
    }
}
