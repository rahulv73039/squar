using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class score : MonoBehaviour
{	

   public Text  scoreText ; 
  

   public void UpdateScore(float scoreNum)
   {
   		scoreText.text =  scoreNum.ToString();
   }

}
