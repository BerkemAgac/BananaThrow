using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject bananaPrefab;
	public Image[] bananas;
	public double bananaRechargeTime;

	private int maxBananaStock;
	private int bananaStock;
	private double timer;
	
	void Start () {
		bananaStock = 5;
		maxBananaStock = 5;
		timer = 0;
	}

	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }

		if (bananaStock < maxBananaStock) {
			timer += Time.deltaTime;
		
			if (timer >= bananaRechargeTime) {
				timer = 0;
				AddBanana ();
			}
		}
	}

    void shoot()
    {
		if (bananaStock == 0)
			return;

        var mousePos = Input.mousePosition;
        mousePos.z = 10;

        var targetPosition = Camera.main.ScreenToWorldPoint(mousePos);
        var playerPosition = this.transform.position;

        GameObject banana = Instantiate(bananaPrefab, playerPosition, Quaternion.identity) as GameObject;

        banana.GetComponent<Move>().setTarget(targetPosition);
		bananaStock--;
		bananas [bananaStock].color = new Color32 (63, 63, 63, 100);
    }

	void AddBanana () {
		bananaStock++;
		bananas [bananaStock-1].color = new Color32 (255, 255, 255, 255);
	}
}
