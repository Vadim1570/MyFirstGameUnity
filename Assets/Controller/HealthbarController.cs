using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    public Image healthBar;
    public float health = 100.0f;
    public float startHealth = 100.0f;

    public void onTakeDamage(float damage)
    {
        addOrRemoveHealth(-1 * damage);
    }

    public void onAddHealth(float some)
    {
        addOrRemoveHealth(some);
    }

    private void addOrRemoveHealth(float delta)
    {
        health = health + delta;
        healthBar.fillAmount = health / startHealth;
    }

}
