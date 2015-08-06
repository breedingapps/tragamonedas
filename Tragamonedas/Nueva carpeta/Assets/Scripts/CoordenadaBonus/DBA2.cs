using UnityEngine;
using System.Collections;

public class DBA2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this,"DBA2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
