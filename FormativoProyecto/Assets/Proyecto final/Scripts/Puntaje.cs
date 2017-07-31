using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour 
{
	public float puntajeGanado = 0f;
	public Text textoDePuntaje;
	public Text textoMayor;
	public Text textoActual;
	public bool resetear = false;

	void Start ()
	{
		puntajeGanado = 0f;
	}

	void Update () 
	{
		if (Application.loadedLevel == 2) 
		{
			puntajeGanado = puntajeGanado + Time.deltaTime * 100;
			Escribir (textoDePuntaje, "PUNTAJE: ", (int)puntajeGanado);
		} 
		else 
		{
			if (Application.loadedLevel == 3)
			{
				Escribir (textoMayor, "PUNTAJE MAYOR: ", RecuperarPuntaje ("Puntaje_Mayor"));
				Escribir (textoActual, "PUNTAJE ACTUAL: ", RecuperarPuntaje ("Puntaje_Actual"));
			}
			else
			{
				if(Application.loadedLevel == 1)
					Escribir (textoMayor, "PUNTAJE MAYOR: ", RecuperarPuntaje ("Puntaje_Mayor"));
			}
		}
		ResetearPuntaje ();
	}

	public void Escribir(Text texto, string titulo, int punt)
	{
		texto.text = titulo + punt;
	}

	public void GuardarPuntaje(string clave, int punt)//Es lo mismo que usar directamente PlayerPrefs.SetInt(clave, punt)
	{
		PlayerPrefs.SetInt (clave, punt);
	}

	public int RecuperarPuntaje(string clave)//Es lo mismo que usar directamente PlayerPrefs.GetInt(clave)
	{
		return PlayerPrefs.GetInt (clave);
	}

	public void CalcularPuntajeMayor(int puntajeActual)
	{
		int puntajeMayor = RecuperarPuntaje ("Puntaje_Mayor");

		if (puntajeMayor == null)//Si existe la clave puntaje mayor en el registro
			GuardarPuntaje ("Puntaje_Mayor", puntajeActual);//Si no existe, creo la clave puntaje_mayor y le asigno el puntaje actual
		else 
		{
			if(puntajeMayor < puntajeActual)//Pregunto si el puntaje actual es mayor al que esta gurdado 
				GuardarPuntaje("Puntaje_Mayor", puntajeActual);//Guardar el puntaje mayor el puntaje actual
		}
	}



	private void ResetearPuntaje()
	{
		if (resetear)
			PlayerPrefs.DeleteAll();
	}
}