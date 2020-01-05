using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{

    public int health = 5;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Target Destroyed");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag + " Entering");
        if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
            currentHealth -= 1;
            Debug.Log("Current health: " + currentHealth);
        }
    }
}
