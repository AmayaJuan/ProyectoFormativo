using UnityEngine;
using System.Collections;

public class PasarEscenas : MonoBehaviour 
{	
	void Start ()
	{
        if (Application.loadedLevel == 0)
            StartCoroutine(PasarNivel());
	}
	
	IEnumerator PasarNivel()
	{
		yield return new WaitForSeconds (3f); 
		Application.LoadLevel(1);
	}

	public void PasarNivel(int x)
	{
		Application.LoadLevel(x);

	}
	public void Salir()
	{
		Application.Quit ();
	}
}
