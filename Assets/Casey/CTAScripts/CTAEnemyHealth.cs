using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTAEnemyHealth : MonoBehaviour
{
    public Slider Enemyslider;

    public void SetMaxHealth(int Health)
    {
        Enemyslider.maxValue = Health;
        Enemyslider.value = Health;
    }

   public void SetHealth(int health)
    {
        Enemyslider.value = health;
    }
}
