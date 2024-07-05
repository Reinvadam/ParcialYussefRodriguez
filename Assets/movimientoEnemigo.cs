using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigo : MonoBehaviour
{
    public float velocidadMovimiento;

    public void Update()
    {
        transform.Translate(0f, 0f, -1f * velocidadMovimiento * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Navecita"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
