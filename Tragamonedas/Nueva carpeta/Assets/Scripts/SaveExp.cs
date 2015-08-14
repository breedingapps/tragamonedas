using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class SaveExp : MonoBehaviour {
	public static SaveExp saveexp;
	
	private string rutaArchivo;

	public int ExpOnMemory = 0;

	void Awake(){
		
		rutaArchivo = Application.persistentDataPath + "/Exp.dat";
		if(saveexp==null){
			saveexp = this;
			DontDestroyOnLoad(gameObject);
		}else if(saveexp!=this){
			Destroy(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		Cargar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Guardar(){
		Debug.Log ("Datos ");
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(rutaArchivo);
		
		SaveData datos = new SaveData();
		datos.ExpObetenida = ExpOnMemory;
		
		bf.Serialize(file, datos);
		
		file.Close();
	}
	void Cargar(){
		if(File.Exists(rutaArchivo)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchivo, FileMode.Open);
			SaveData datos = (SaveData) bf.Deserialize(file);
			
			
			ExpOnMemory = datos.ExpObetenida;
			
			file.Close();
		}else{
			ExpOnMemory = 0;
		}
	}
}

[Serializable]
class SaveData{
	public int ExpObetenida;
}

