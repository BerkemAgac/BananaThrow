using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject bananaPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
	}

    void shoot()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 10;

        var targetPosition = Camera.main.ScreenToWorldPoint(mousePos);
        var playerPosition = this.transform.position;

        GameObject banana = Instantiate(bananaPrefab, playerPosition, Quaternion.identity) as GameObject;

        banana.GetComponent<Move>().setTarget(targetPosition);
    }
}
