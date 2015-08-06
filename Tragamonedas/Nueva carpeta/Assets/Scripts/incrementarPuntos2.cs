using UnityEngine;
using System.Collections;

public class incrementarPuntos2 : MonoBehaviour {
	private int puntosGanados = 1;
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", puntosGanados);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
