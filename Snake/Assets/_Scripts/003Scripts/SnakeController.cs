using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour {

    public EasyJoystick joyStack;
    public float _Speed;

    void Update()
    {
        Vector3 temp = joyStack.JoystickAxis;
        transform.position += temp * _Speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(new Vector3( temp.x,temp.y,0));
    }

   
}
