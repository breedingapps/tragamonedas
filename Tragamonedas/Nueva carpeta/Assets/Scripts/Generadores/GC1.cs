using UnityEngine;
using System.Collections;

public class GC1 : MonoBehaviour {

	public GameObject[] obj;
	private bool BonusActive = false;
	//public float tiempoMin = 1.25f;
	//public float tiempoMax = 2.5f;
	private bool fin = false;
	
	
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DBC1");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionadoDeNuevo");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BotonPresionado");
		
	}
	void DBC1(){
		BonusActive = true;
	}
	void BotonPresionadoDeNuevo (){
		fin = false;
		Generar ();
	}
	void BotonPresionado(){
		fin = true;
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	void Volver(){
		fin = true;
		BonusActive = false;
	}
	void Generar(){
		if(!fin){
			if(BonusActive){
			Instantiate(obj[Random.Range(0,obj.Length)],transform.position, Quaternion.identity);
				Debug.Log("ACTIVOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
			}else{
				Instantiate(obj[Random.Range(0,7)],transform.position, Quaternion.identity);
				Debug.Log("no");
			}
				NotificationCenter.DefaultCenter().PostNotification(this, "PayLineCheck");
			NotificationCenter.DefaultCenter().PostNotification(this, "Generador2");
			Volver();
		}
		
	}
	
}
