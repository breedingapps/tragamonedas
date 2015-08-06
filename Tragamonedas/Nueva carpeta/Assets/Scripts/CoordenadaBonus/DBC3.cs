using UnityEngine;
using System.Collections;

public class DBC3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBC3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
