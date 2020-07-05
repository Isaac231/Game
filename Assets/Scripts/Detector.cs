using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
	public string Deteccion;
    private float presion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){
    	if (col.gameObject.tag == "Nota"){
    		Deteccion= "Si";

    	}
    }
    void OnTriggerExit2D(Collider2D col){
    	if (col.gameObject.tag == "Nota"){
    		Deteccion= "Si";
    	}
    }
    void FixedUpdate(){
          if (Input.GetKeyDown(KeyCode.D)) {
            presion= 1f; 
            Debug.Log("Presiono");
        }
          if(Input.GetKeyUp(KeyCode.D)) {
            presion= 0f;
            Debug.Log("Dejo de presionar");

          }

    }
}
