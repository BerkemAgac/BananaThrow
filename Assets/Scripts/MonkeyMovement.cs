using UnityEngine;
using System.Collections;

public class MonkeyMovement : MonoBehaviour {

	public float moveSpeed;

	private bool isGround;
	private Animator animatorAC;

	void Start () {
		animatorAC = GetComponent <Animator> ();
	}

	void Update () {
		if (!isGround) {
			Vector3 newPosition = transform.position;
			newPosition.y -= moveSpeed;
			transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
		}

	}

	void OnTriggerEnter2D(Collider2D other) {
		isGround = true;
		animatorAC.SetBool ("IsGround",true);
	}
}
