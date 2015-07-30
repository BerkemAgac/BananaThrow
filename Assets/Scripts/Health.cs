using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health;
	
	// Update is called once per frame
	void Update ()
    {
	    if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
