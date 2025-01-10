using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    public VariableJoystick joystick;
    public  swipeZone swipeZone;
    public static float swipeZoneInput;
    public static float joystickInputVertical;
    public static float joystickInputHorizontal;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        swipeZoneInput = swipeZone.CursorMovement;
        joystickInputHorizontal = joystick.Horizontal;
        joystickInputVertical = joystick.Vertical;
    }
        
}