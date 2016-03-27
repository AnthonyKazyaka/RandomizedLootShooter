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
    
    // Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
    private void Update()
    {

    }

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
    }
}
