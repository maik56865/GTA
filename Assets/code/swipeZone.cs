using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class swipeZone : MonoBehaviour
{
    // Start is called before the first frame update
    public float CursorMovement;
    public Vector2 cursorPos;
    public Vector2 cursorOldPos;



    public void OnDrag()
    {
        Vector2 cursorNewpos;
        cursorNewpos = Input.mousePosition;
        CursorMovement = cursorNewpos.x - cursorPos.x;
        cursorPos = cursorNewpos;
    }
    public void BeginDrag()

    {
        cursorPos = Input.mousePosition;

    }
    public void EndDrag()
    {
        CursorMovement = 0;
    }
}
