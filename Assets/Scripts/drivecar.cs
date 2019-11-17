using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bose.Wearable;
//using System;


public class drivecar : MonoBehaviour
{
	public float speed;
	//private double ax;
    //private double ay; 
    //private double az;

	Rigidbody rb;
	WearableControl wearableControl;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        wearableControl = WearableControl.Instance;
        WearableRequirement requirement = GetComponent<WearableRequirement>();
        if(requirement == null)
        {
        	requirement = gameObject.AddComponent<WearableRequirement>();
        }
        requirement.EnableSensor(SensorId.RotationSixDof);
        requirement.SetSensorUpdateInterval(SensorUpdateInterval.EightyMs);
    }

    // Update is called once per frame
    void Update()
    {

    	

        if (wearableControl.ConnectedDevice == null)
        {
        	return;
        }

        SensorFrame sensorFrame = wearableControl.LastSensorFrame;

        //ax = sensorFrame.rotationSixDof.value.x;
    	//ay = sensorFrame.rotationSixDof.value.y;
    	//az = sensorFrame.rotationSixDof.value.z;

        float moveHorizontal = -sensorFrame.rotationSixDof.value.z;  // (float) Math.Sqrt((ax*ax) + (ay*ay) + (az*az));

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rb.AddForce(movement * speed);
    	}
    }
