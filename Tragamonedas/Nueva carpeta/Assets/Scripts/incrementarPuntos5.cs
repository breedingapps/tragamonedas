using UnityEngine;
using System.Collections;

public class incrementarPuntos5 : MonoBehaviour {
	private int puntosGanados = 2;


	// Use this for initialization
	void Start () {
		
		NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", puntosGanados);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
