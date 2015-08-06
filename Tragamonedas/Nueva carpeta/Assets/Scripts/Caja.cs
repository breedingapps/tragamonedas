using UnityEngine;
using System.Collections;

public class Caja : MonoBehaviour {

	private int TotalMonedas = 0;
	public TextMesh monedas;	
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		ActualizarMarcador ();
	}
	
	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		TotalMonedas +=puntosAIncrementar;
		ActualizarMarcador ();


	}
	void ActualizarMarcador(){
		monedas.text = TotalMonedas.ToString ();
		Debug.Log (TotalMonedas);
		// Update is called once per frame
	}
	void Update () {
		
	}
}
