using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{  
	public GameObject enemyGun;  
	public GameObject eBullet;  
	public scoreupdate scoreUp;
	public ParticleSystem deathEffect;
	public float waitingTime; 
	public float eBullspeed; 
	public float increment=5f;
	Vector3 enemyGundir;  
	GameObject player; 
	GameObject bullet; 
	float timer=0f;
	
  
    void Start()
    {
      player = GameObject.FindWithTag("Player"); 
      bullet  = GameObject.Find("bullets");
    }

  
    void Update()
    {  timer+= Time.deltaTime;
       enemyGundir = player.transform.position  - enemyGun.transform.position;
       var angle  = Mathf.Atan2(enemyGundir.y,enemyGundir.x)*Mathf.Rad2Deg;
       enemyGun.transform.rotation =  Quaternion.AngleAxis(angle,Vector3.forward);  
      WaitForFire();
      
    }   

    void WaitForFire()
    { 
    	if(timer >= waitingTime)
    	{ 	
    		timer =0f;
    		fire();
    	}
    }  

     void fire()
     {
     	Vector3 velDir = Vector3.Normalize(enemyGundir);
     	GameObject instEBullet =  Instantiate(eBullet,enemyGun.transform.position+ velDir,Quaternion.identity) as GameObject;
     	Rigidbody2D rgdBdOfEbull  = instEBullet.GetComponent<Rigidbody2D>(); 
     	rgdBdOfEbull.velocity =  velDir*eBullspeed;
     }

     void OnCollisionEnter2D(Collision2D coll)
     {
     	if(coll.collider.tag == "bullet")
     	{    
     		Destroy(gameObject);  
     		scoreUp.PointUp(increment);
     		Instantiate(deathEffect,transform.position,Quaternion.identity);

     	}
     }

  
}
