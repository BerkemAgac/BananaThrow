using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    public float speed;
	public int score;

	private bool isGround;
	private Animator animatorAC;

    private Health h;

	void Start ()
    {
        h = GetComponent<Health>();
		animatorAC = GetComponent <Animator> ();
	}

	void Update ()
    {
		if (!isGround) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        h.health -= coll.gameObject.GetComponent<Damage>().getDamage();
		animatorAC.SetTrigger ("Happy");
        
        Destroy(coll.gameObject);
    }

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("TRIGGER");
		if (other.tag == "Ground") {
			isGround = true;
			animatorAC.SetBool ("IsGround", true);
		}
	}
}