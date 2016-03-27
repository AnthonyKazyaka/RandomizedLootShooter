using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private Vector3 _direction = new Vector3();
    public Vector3 Direction {get { return _direction; } set { _direction = value; }}

    [SerializeField]
    private float _speed = 0.0f;
    public float Speed {get { return _speed; } set { _speed = value; }}

    [SerializeField]
    private Vector3 _acceleration = new Vector3();
    public Vector3 Acceleration {get { return _acceleration; } set { _acceleration = value; }}

    private float _lifetime = 5.0f;
    public float Lifetime {get { return _lifetime; } set { _lifetime = value; }}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
