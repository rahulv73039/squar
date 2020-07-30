using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterspawneffect : MonoBehaviour
{	public float time; 
	public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,time); 
        StartCoroutine(AfterEffect());
    }

   IEnumerator AfterEffect()
   {
   		yield return new WaitForSeconds(2.0f);
   		Instantiate(enemy,transform.position,Quaternion.identity); 
   		yield return null;
   }


}
