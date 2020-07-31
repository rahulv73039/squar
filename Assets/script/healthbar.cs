using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
   public Slider slider; 
   public Gradient gradient; 
   public Image bar;
   
   public void SetMaxHealth(float maxHealth)
   {
   		slider.maxValue = maxHealth;
   		slider.value  =  maxHealth; 
   		bar.color = gradient.Evaluate(1f);

   } 
    public void SetHealth(float health)
    {
    	slider.value = health;
    	bar.color  = gradient.Evaluate(slider.normalizedValue);
    }

}
