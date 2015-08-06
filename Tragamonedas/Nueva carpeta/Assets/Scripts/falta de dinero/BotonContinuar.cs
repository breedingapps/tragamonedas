using UnityEngine;
using System.Collections;

public class BotonContinuar : MonoBehaviour {
	public GameObject MoreCoins;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown(){
		NotificationCenter.DefaultCenter ().PostNotification (this, "MoreCoins");

		MoreCoins.SetActive (false);

	}
	// Update is called once per frame
	void Update () {
	
	}
}
