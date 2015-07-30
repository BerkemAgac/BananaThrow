using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    public GameObject spawnPointLeft;
    public GameObject spawnPointRight;

    Vector3 spawnLocation;

    public GameObject monkey;

	// Use this for initialization
	void Start ()
    {
        spawnLocation = spawnPointLeft.transform.position;
        InvokeRepeating("spawnMonkeys", 1, 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void spawnMonkeys()
    {
        spawnLocation.x = Random.Range(spawnPointLeft.transform.position.x, spawnPointRight.transform.position.x);
        GameObject go = Instantiate(monkey, spawnLocation, Quaternion.identity) as GameObject;
    }
}
