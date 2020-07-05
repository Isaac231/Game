using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlataforma : MonoBehaviour
{
	public float Velocidad=1f;
	public float Direccion;
	private Rigidbody2D _rigidbody2d;
	private Vector2 _movimiento;

    // Start is called before the first frame update
    void Awake(){
    	_rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
    	_movimiento = new Vector2(Direccion, 0f);
        
    }
    void FixedUpdate(){
    	float horizontalVelocity = _movimiento.normalized.x * Velocidad;
    	_rigidbody2d.velocity = new Vector2(horizontalVelocity, _rigidbody2d.velocity.y);

    }
}
