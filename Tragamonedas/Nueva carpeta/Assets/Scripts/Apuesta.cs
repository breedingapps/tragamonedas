using UnityEngine;
using System.Collections;

public class Apuesta : MonoBehaviour {

	private float Tiempo= 5.0f;
	public TextMesh apuesta;
	public TextMesh monedas;
	public TextMesh win;
	private int monto = 0;
	private int TotalMonedas = 1000;
	private int Ganancia = 0;
	private int Aumentar= 5;
	
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "AumentarApuesta");
		//	NotificationCenter.DefaultCenter().AddObserver(this, "ActualizarTotal");
		NotificationCenter.DefaultCenter().AddObserver(this, "Figura1A5");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BotonPresionadoDeNuevo");
		
	}
	void AumentarApuesta(){
		monto = monto + Aumentar;
		TotalMonedas = TotalMonedas - monto;
		monedas.text = TotalMonedas.ToString ();
		Actualizar ();
	}
	
	
	/*void prueba(){
		Tiempo -= Time.deltaTime;
		if (Tiempo <= 0) {
			Debug.Log("Timer ON");
			Debug.Log (TotalMonedas);
			monto = 0;
		}

		}
	void BotonPresionadoDeNuevo (){
		Tiempo -= Time.deltaTime;
		if (Tiempo <= 0) {
			Debug.Log("Timer ON");
			Debug.Log (TotalMonedas);
			monto = 0;
		}


	}*/
	// Update is called once per frame
	void Update () {
		
		
	}
	void Actualizar(){
		
		apuesta.text = monto.ToString ();
		
	}
	void Figura1A5 (){
		
		Ganancia = monto * 10;
		win.text = Ganancia.ToString ();
		
		
		TotalMonedas += Ganancia;
		monedas.text = TotalMonedas.ToString ();
		Debug.Log (TotalMonedas);
		
		
	}
}