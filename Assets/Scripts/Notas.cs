using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
	private float velocidad= 2f;
	private Vector2 _direction;
	private Rigidbody2D _rigidBody;
	public float speed= -2f;
    public string siONo;
    
    // Start is called before the first frame update
    void Start()
    {
        Detector confirm = GetComponent<Detector>();
    	_rigidBody = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
    	float horizontalInput = velocidad;
       _direction = new Vector2(horizontalInput, 0f);
              

        
    }
    void FixedUpdate()
    {
     float horizontalVelocity= _direction.normalized.x * speed;
     _rigidBody.velocity = new Vector2(horizontalVelocity, _rigidBody.velocity.y);
    
    
    }
}
