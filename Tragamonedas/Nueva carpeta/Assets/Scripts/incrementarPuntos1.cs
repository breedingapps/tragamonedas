using UnityEngine;
using System.Collections;

public class incrementarPuntos1 : MonoBehaviour {



	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "A1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
