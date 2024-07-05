using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Transform instancia;
    
    public GameObject bala;

    public float fuerza;

    public Vector3 distanciaDisparo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(bala, instancia.position, bala.transform.rotation);
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * fuerza);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(instancia.position, distanciaDisparo);
    }
}
