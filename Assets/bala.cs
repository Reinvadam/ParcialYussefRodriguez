using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NaveMala"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
