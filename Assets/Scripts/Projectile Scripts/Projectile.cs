using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public float Speed { get { return _speed; } set { _speed = value; } }

    [SerializeField]
    private float _damage;
    public float Damage { get { return _damage; } set { _damage = value; } }

    [SerializeField]
    private Vector3 _direction = new Vector3();
    public Vector3 Direction { get { return _direction; } set { _direction = value.normalized; } }

    [SerializeField]
    private Vector3 _acceleration = new Vector3();
    public Vector3 Acceleration { get { return _acceleration; } set { _acceleration = value; } }

    [SerializeField]
    private float _lifetime = 5.0f;
    public float Lifetime { get { return _lifetime; } set { _lifetime = value; } }

    private float _timeOfCreation = Time.time;

    // Use this for initialization
    private void Start ()
    {
	    
	}
	
	// Update is called once per frame
	private void Update()
    {

    }


    private void FixedUpdate()
    {
        if(Time.time < _timeOfCreation + Lifetime)
        {
            Vector3 movement = Direction
            gameObject.GetComponent<Rigidbody>().MovePosition(Direction * )
        }
    }
}
