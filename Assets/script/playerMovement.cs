using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{     
	SpringJoint2D joint;  
	Rigidbody2D rgdBd; 
	public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {   joint = GetComponent<SpringJoint2D>();
        joint.enabled =false;  
        rgdBd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	 
	} 

    void FixedUpdate()
    {    
       if(Input.GetAxisRaw("Horizontal") !=0f )
       {
       	float horizontalMove =  Input.GetAxisRaw("Horizontal")*speed*2f;
       	
       	rgdBd.AddForce(new Vector2(horizontalMove,0f));

       } 
       if(Input.GetAxisRaw("Vertical") !=0f)
       {
       	float verticalMove   = Input.GetAxisRaw("Vertical")*speed*2f;
       	rgdBd.AddForce(new Vector2(0f,verticalMove)); 
       }
    }
}
