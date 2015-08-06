using UnityEngine;
using System.Collections;

public class DBA1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this,"DBA1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
