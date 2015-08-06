using UnityEngine;
using System.Collections;

public class BA5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BA5");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
