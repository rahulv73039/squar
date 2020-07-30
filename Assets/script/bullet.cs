using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{   
	public ParticleSystem bulletParticle;
 // Important -Use 2D suffix in 2D game it eats my 2-3 hours  
    void OnCollisionEnter2D(Collision2D coll)
 	{
 		// if(coll.collider.name == "enemy")
 		// {
 		// 	Destroy(gameObject);
 		// } 
 	if(coll.collider.tag == "wall")
 	{ 	
 		Instantiate(bulletParticle,transform.position,Quaternion.identity);
 		Destroy(gameObject);
 	}
	 }




}
