using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreupdate : MonoBehaviour
{	
	 public score scoreNum; 
	 static float currentScore = 0f;
    // Start is called before the first frame update
    void Start()
    {
     	scoreNum.UpdateScore(0f);   
    } 
    void Update()
    {
    	scoreNum.UpdateScore(currentScore);
    }
    public void PointUp(float increment)
    {
    	currentScore+=increment;
    	
    }
   
}
