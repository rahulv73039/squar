using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{   
	public ParticleSystem bulletParticle;
	void start()
	{
		Destroy(gameObject,7f);
	}
 // Important -Use 2D suffix in 2D game it eats my 2-3 hours  
    void OnCollisionEnter2D(Collision2D coll)
 	{
 		if(coll.collider.tag == "enemy")
 		{
 			Destroy(gameObject);
 		} 
 	if(coll.collider.tag == "wall" || coll.collider.tag == "ebullet")
 	{ 	
 		Instantiate(bulletParticle,transform.position,Quaternion.identity);
 		Destroy(gameObject);
 	}
	 }




}
