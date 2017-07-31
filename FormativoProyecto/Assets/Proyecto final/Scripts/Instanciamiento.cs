using UnityEngine;
using System.Collections;

/// <summary>
/// Instanciamiento.Este script instancia los prefab de las plataformas
/// </summary>

public class Instanciamiento : MonoBehaviour 
{
	public GameObject[] plataformas;
	public float minimo = 1f;
	public float maximo = 2f;
	
	void Start () 
	{
		InstanciarPlataformas ();
		//InstanciarEstrellas ();
	}

	void InstanciarPlataformas () 
	{
		Instantiate (plataformas [Random.Range (0, plataformas.Length)], transform.position, Quaternion.identity);
		Invoke("InstanciarPlataformas", Random.Range(minimo, maximo));//Llama la funcion infinitamente
	}
}
