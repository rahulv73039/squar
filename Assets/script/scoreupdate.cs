using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreupdate : MonoBehaviour
{	
	  
	 public static float currentScore = 0f;
    // Start is called before the first frame update
    void Start()
    {    //Better way to acces scripts 
    	currentScore = 0f;
    	FindObjectOfType<score>().UpdateScore(0f);   
    } 
    void Update()
    {
    	FindObjectOfType<score>().UpdateScore(currentScore);
    }
    public void PointUp(float increment)
    {
    	currentScore+=increment;
    	
    }
   
}
