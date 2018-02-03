using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody2D rBody = this.gameObject.GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(2, 1);//two unit to the x one unit in y

	}
	
	/* Update is called once per frame
	void Update () {
		
	}
    //this will guarantee a consistent call in term of time
    void FixedUpdate()
    {
        
    }*/
}
