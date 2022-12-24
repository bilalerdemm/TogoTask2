using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoove : MonoBehaviour
{
    public FloatingJoystick floatingJoystick;
    public GameObject bg;
    public float speed;
  
    void Update()
    {
        Vector3 direction = Vector3.forward * floatingJoystick.Vertical + Vector3.right * floatingJoystick.Horizontal;
        transform.position = direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 10f * Time.deltaTime);
    }
}
