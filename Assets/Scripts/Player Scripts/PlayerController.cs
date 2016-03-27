using System;
using UnityEngine;
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

    private Vector3 _lookDirection = new Vector3();

    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

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

        gameObject.GetComponent<Rigidbody>().MovePosition(movementVector);
    }
}