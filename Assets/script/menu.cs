using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
   public string gameScene ;
  
   
   public void  PlayGame()
   {
  	 	SceneManager.LoadScene(gameScene);
   } 

   public void AboutGame()
   {
   		
   }

   public void Quitgame()
   {
   		Application.Quit();
   } 


}
