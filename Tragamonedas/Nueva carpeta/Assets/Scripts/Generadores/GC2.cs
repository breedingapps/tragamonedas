using UnityEngine;
using System.Collections;

public class GC2 : MonoBehaviour {
	public GameObject[] obj;
	private bool BonusActive = false;
	//public float tiempoMin = 1.25f;
	//public float tiempoMax = 2.5f;
	private bool fin = false;
	
	
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DBC2");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionadoDeNuevo");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BotonPresionado");
		NotificationCenter.DefaultCenter().AddObserver(this, "Generador2");
		
	}
	void DBC2(){
		BonusActive = true;
	}
	void Generador2 (){
		fin = false;
		Invoke ("Generar", 1.0f);
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

			}else{
				Instantiate(obj[Random.Range(0,7)],transform.position, Quaternion.identity);
				Debug.Log("no");
			}
				NotificationCenter.DefaultCenter().PostNotification(this, "PayLineCheck");
			NotificationCenter.DefaultCenter().PostNotification(this, "Generador3");
			NotificationCenter.DefaultCenter().PostNotification(this, "Parallax2");


			Volver();
		}
		
	}
	
}
