<<<<<<< HEAD
﻿using UnityEngine;
=======
﻿using System;
using UnityEngine;
>>>>>>> 8f141e322de0cd0a1d57f599979cef853fe1b881
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private float _movementSpeed = 5.0f;
    public float MovementSpeed
    {
        get { return _movementSpeed; }
        private set { _movementSpeed = value; }
    }

    private float _minimumThumbstickThreshold = 0.05f;
<<<<<<< HEAD
    
    // Use this for initialization
	void Start () 
=======

    private Vector3 _lookDirection = new Vector3();
    
    // Use this for initialization
	private void Start () 
>>>>>>> 8f141e322de0cd0a1d57f599979cef853fe1b881
    {
	
	}
	
	// Update is called once per frame
    private void Update()
    {

    }

<<<<<<< HEAD
    void FixedUpdate()
    {
        Vector3 movementVector = Vector3.zero;
        if (Mathf.Abs(Xbox360Controller.Player1Contoller.LeftThumbstickX) > _minimumThumbstickThreshold)
        {
            movementVector += Xbox360Controller.Player1Contoller.LeftThumbstickX * gameObject.transform.right;
            Debug.Log("Player 1 X!");
        }
        if (Mathf.Abs(Xbox360Controller.Player1Contoller.LeftThumbstickY) > _minimumThumbstickThreshold)
        {
            movementVector += Xbox360Controller.Player1Contoller.LeftThumbstickY * gameObject.transform.forward;
            Debug.Log("Player 1 Y!");
        }

        movementVector = gameObject.transform.position + (movementVector * MovementSpeed * Time.deltaTime);

        Debug.Log(movementVector);
        gameObject.GetComponent<Rigidbody>().MovePosition(movementVector);
=======
    private void FixedUpdate()
    {
        CheckThumbstickInput();
    }

    private void CheckThumbstickInput()
    {
        Vector3 movementVector = Vector3.zero;
        if (Mathf.Abs(Xbox360Controller.Player1Contoller.LeftThumbstickX) >= _minimumThumbstickThreshold)
        {
            movementVector += Xbox360Controller.Player1Contoller.LeftThumbstickX * Vector3.right;
            Debug.Log("Player 1 X!");
        }
        if (Mathf.Abs(Xbox360Controller.Player1Contoller.LeftThumbstickY) >= _minimumThumbstickThreshold)
        {
            movementVector += Xbox360Controller.Player1Contoller.LeftThumbstickY * Vector3.forward;
            Debug.Log("Player 1 Y!");
        }

        if (Math.Abs(Xbox360Controller.Player1Contoller.RightThumbstickX) + Math.Abs(Xbox360Controller.Player1Contoller.RightThumbstickY) < _minimumThumbstickThreshold)
        {
            if (movementVector.magnitude > _minimumThumbstickThreshold)
            {
                _lookDirection = movementVector.normalized;
            }
        }
        else
        {
            _lookDirection.x = Xbox360Controller.Player1Contoller.RightThumbstickX;
            _lookDirection.y = 0.0f;
            _lookDirection.z = -Xbox360Controller.Player1Contoller.RightThumbstickY;
            _lookDirection.Normalize();
        }

        gameObject.transform.forward = _lookDirection;

        movementVector = gameObject.transform.position + (movementVector * MovementSpeed * Time.deltaTime);

        gameObject.rigidbody.MovePosition(movementVector);
>>>>>>> 8f141e322de0cd0a1d57f599979cef853fe1b881
    }
}
