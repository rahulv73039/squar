using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebullets : MonoBehaviour
{   
	public ParticleSystem ebulletBreak; 
	void start()
	{
		Destroy(gameObject,7f);
	}

    void OnCollisionEnter2D(Collision2D other)
    {	
    	if(other.collider.tag == "Player")
   	 	{
   	 		Destroy(gameObject);
    	}
    	if(other.collider.tag == "wall" || other.collider.tag == "bullet")
    	{
    		 Instantiate(ebulletBreak,transform.position,Quaternion.identity) ;
    		 Destroy(gameObject);
    	}
    }
 
}
