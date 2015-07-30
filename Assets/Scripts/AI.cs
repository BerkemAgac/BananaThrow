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
        h.currentHealth -= coll.gameObject.GetComponent<Damage>().getDamage();

        Destroy(coll.gameObject);
    }
}