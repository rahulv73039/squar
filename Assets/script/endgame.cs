using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
public class endgame : MonoBehaviour
{	
	public Text scoreDisplay; 
	public Text scoreText ; 
	public static bool isGameover =false; 
	public GameObject endGameUI;
	bool shown =false; //since showendgame method is in update method so to prevent loop;
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text =  scoreText.text;
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text =  scoreText.text; 
        if(isGameover && (shown==false))
        {
        	ShowEndGame();
        }
    }  
   

   public void ShowEndGame()
    {	shown=true;
    	isGameover=true ; 
    	Time.timeScale = 0f;
    	endGameUI.SetActive(true);
    } 

    public void restart()
    {	shown=false;
    	isGameover =false ; 
    	Time.timeScale = 1f; 
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    } 
    public void menu()
    {	shown=false;
    	isGameover = false; 
    	Time.timeScale = 1f;
    	 SceneManager.LoadScene(0);
    }



}
