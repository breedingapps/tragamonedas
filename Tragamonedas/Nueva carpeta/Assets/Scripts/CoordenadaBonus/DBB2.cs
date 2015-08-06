using UnityEngine;
using System.Collections;

public class DBB2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBB2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
