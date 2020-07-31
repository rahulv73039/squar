using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public float maxHealth =100f; 
    public float damageAmount =20f;
    public healthbar healthBar; 
    float currentHealth ; 


    void Start()
    {	
        currentHealth =  maxHealth ;
        healthBar.SetMaxHealth(currentHealth);
    }

    
    void Update()
    {
       if(currentHealth <=0)
       {	
       		Destroy(gameObject);
       } 
    } 

    void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.collider.tag == "ebullet")
    	{
    		damage(damageAmount);
    	}
    }

    void damage(float damageAmount)
    {
    	currentHealth-= damageAmount;
    	healthBar.SetHealth(currentHealth);
    }
}
