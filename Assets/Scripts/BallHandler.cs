using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
            return;

       Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        //	Transforms a point from screen space into world space,
        //  where world space is defined
        //  as the coordinate system at the very top of your game's hierarchy.

        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);
        Debug.Log(worldPosition);
    }
}
