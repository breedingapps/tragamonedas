using UnityEngine;
using System.Collections;

public class DBC4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBC4");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
