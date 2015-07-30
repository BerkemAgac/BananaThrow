using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Vector3 targetPosition = Vector3.zero;
    public float speed;
    public float rotationSpeed;

	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        rotate();

        transform.position += targetPosition * speed * Time.deltaTime;
	}

    public void setTarget(Vector3 targetPos)
    {
        targetPosition = (targetPos - transform.position).normalized;
    }

    void rotate()
    {
        transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
    }
}
