using UnityEngine;
using System.Collections;

public class ProbabilidadBonus : MonoBehaviour {
	private bool Condicion= false;
	private int contador= 0;
	public GameObject[] BonusCoordenada;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "Parallax5");
	}
	void Parallax5(){

		contador += 1;

		if (contador == 10) {
			Condicion=true;		
		}
	}
	void Begin(){

		contador = 0;
		Condicion = false;
	}
	// Update is called once per frame
	void Update () {
		if (Condicion) {
			Instantiate(BonusCoordenada[Random.Range(0,BonusCoordenada.Length)],transform.position, Quaternion.identity);
			Begin();
		}
	
	}
}
