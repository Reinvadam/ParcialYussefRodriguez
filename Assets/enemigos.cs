using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    public Transform[] instancia;

    public GameObject instanciaEnemigo;
    private int numeroRandom;

    public float tiempo;

    private void Start()
    {
        StartCoroutine(tiempoEnemigo());
    }

    IEnumerator tiempoEnemigo()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(instanciaEnemigo, instancia[numeroRandom]);
            numeroRandom = Random.Range(0, instancia.Length);
        }
    }
}
