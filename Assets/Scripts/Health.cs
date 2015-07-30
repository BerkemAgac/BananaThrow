using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float currentHealth;
    public GameObject healthBarPrefab;

    GameObject healthBar;

    void Awake()
    {
        //healthBar = Instantiate(healthBarPrefab, transform.position, Quaternion.identity) as GameObject;
        //healthBar.transform.parent = transform;
    }
    void Start()
    {
       
    }

	// Update is called once per frame
	void Update ()
    {

	}

    public float getHealth()
    {
        return currentHealth;
    }

    public void setHealth(float health)
    {
        currentHealth = health;
    }

    public void reduceHealth(float amount)
    {
        currentHealth -= amount;
    }
}
