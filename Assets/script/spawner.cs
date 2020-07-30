using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{	
	public Vector3 spawnLocation; 
	public ParticleSystem spawnEffect;
	public float startWait ;
	public float waitLeast ;
	public float waitMost ; 
	public bool stop;
	float spawnWait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(waitLeast,waitMost);
    } 

    IEnumerator spawn()
    { 	
    	yield return new WaitForSeconds(startWait);
    	while(!stop)
    	{
    		Vector3 spawnPosition  = new Vector3(Random.Range(-spawnLocation.x ,spawnLocation.x),Random.Range(-spawnLocation.y,spawnLocation.y),0f);
    	  	Instantiate(spawnEffect,spawnPosition,Quaternion.identity);
    	  	yield return new WaitForSeconds(spawnWait);
    	}

    }
}
