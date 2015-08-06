using UnityEngine;
using System.Collections;

public class DBC2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBC2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
