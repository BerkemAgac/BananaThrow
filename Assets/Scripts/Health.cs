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
        //healthBar.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}
}
