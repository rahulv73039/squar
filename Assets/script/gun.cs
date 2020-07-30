using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{   public GameObject bullet; 
	public float bullSpeed; 
	Vector3 dir; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position) ;
       var angle  = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg;
       transform.rotation =  Quaternion.AngleAxis(angle,Vector3.forward);
       
       if(Input.GetKeyDown(KeyCode.F))
       {  	
       	Vector3 velDir  =  Vector3.Normalize(dir);
       	GameObject instBullet  =  Instantiate(bullet,transform.position+velDir,Quaternion.identity) as GameObject;
       	Rigidbody2D rigidBull = instBullet.GetComponent<Rigidbody2D>();  
       
       	rigidBull.velocity = bullSpeed*velDir;

       }

    }
}
