using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	public GameObject helpDialog;

	public void ShowHelpDialog () {
		helpDialog.SetActive (true);
		helpDialog.transform.position = Vector3.zero;
	}
	
	public void HideHelpDialog () {
		helpDialog.transform.position = new Vector3 (2000f, 0f, 0f);
		helpDialog.SetActive (false);
	}
}
