using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Joystick joystick;


    public Transform target { get; set; }
    private void Update()
    {
        ControlTarget();
    }

    void ControlTarget()
    {
        if (target)
        {
            target.localScale += joystick.Vertical * Time.deltaTime * Vector3.one / 10;
            target.Rotate(0, joystick.Horizontal * Time.deltaTime * 100, 0);
        }
    }
}
