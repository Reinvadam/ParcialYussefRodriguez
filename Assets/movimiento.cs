using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(movimientoHorizontal, 0f, 0f) * velocidad * Time.deltaTime;
    }

}
