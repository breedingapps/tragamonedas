using UnityEngine;
using System.Collections;

public class DBC1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBC1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
