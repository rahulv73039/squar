using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
{
   public static bool gameIspaused = false;
   public GameObject pauseMenuUI;

   
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
       		if(gameIspaused == false)
       		{
       			pause();
       		} 
       		else 
       		{
       			resume();
       		}
       } 
    } 
   public void resume()
    {
    	pauseMenuUI.SetActive(false); 
    	Time.timeScale =1f;
    	gameIspaused=false;
    } 
    void pause()
    {
    	pauseMenuUI.SetActive(true) ;
    	Time.timeScale = 0f;
    	gameIspaused = true;
    } 
    public void quit()
    {
    	Application.Quit();
    } 
    public void menu()
    {    gameIspaused =false;
         Time.timeScale =1f;
         SceneManager.LoadScene(0);
    }
}
