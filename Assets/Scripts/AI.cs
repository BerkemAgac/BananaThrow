using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    public float speed;

    Health h;

	// Use this for initialization
	void Start ()
    {
        h = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        h.reduceHealth(coll.gameObject.GetComponent<Damage>().getDamage());

        if (h.getHealth() <= 0)
        {
            Destroy(gameObject);
        }

        Destroy(coll.gameObject);
    }
}