using UnityEngine;
using System.Collections;

public class DBC5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBC5");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
