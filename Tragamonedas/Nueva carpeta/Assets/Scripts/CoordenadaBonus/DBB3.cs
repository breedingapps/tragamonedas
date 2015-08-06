using UnityEngine;
using System.Collections;

public class DBB3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBB3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
