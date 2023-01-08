using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope : MonoBehaviour
{
    
    void Start()
    {
        SuportGyroscope();
    }

    private void SuportGyroscope()
    {
        Input.gyro.enabled = true;
        if (SystemInfo.supportsGyroscope)
        {
           
        }
    }

    void Update()
    {
       // if(StatesGame.GetIsGyroscope())
        RotationWithGyroscope();
    }

    private void RotationWithGyroscope()
    {
        transform.rotation = Input.gyro.attitude;
    }

    private Quaternion GyroControll(Quaternion quaternion)
    {
        return new Quaternion(quaternion.x, quaternion.y, -quaternion.z, -quaternion.w);
    }
}
