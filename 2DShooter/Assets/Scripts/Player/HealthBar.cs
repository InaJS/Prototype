using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Health bar script. Public allows other scripts to access this script.
    public Slider Slider;

    //Health bar changes colour with a gradient
    public Gradient Gradient;
    public Image Fill;

    public void SetMaxHealth(int Health)
    { 
        Slider.maxValue = Health;
        Slider.value = Health;

        //Use Evaluate to pick a specific colour from the gradient. 
        //1F is all the way to the right of the gradient, and 0 is all the way to the left
        Fill.color = Gradient.Evaluate(1f);
    }

    public void SetHealth(int Health)
    {
        Slider.value = Health;

        Fill.color = Gradient.Evaluate(Slider.normalizedValue);
    }
    
}
