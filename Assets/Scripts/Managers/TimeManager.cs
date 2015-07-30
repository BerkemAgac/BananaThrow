using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public int secondsToEnd;
	
	Text text;
	
	void Awake ()
	{
		text = GetComponent <Text> ();
	}
	
	void Update ()
	{
		int timeRemain = secondsToEnd - (int)Time.time;
		text.text = timeRemain.ToString();
		if (timeRemain <= 0) {
			GameController.GameOver();
		}
	}
}
