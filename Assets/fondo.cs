using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour
{
    public Vector2 velocidadFondo;

    private Vector2 offset;

    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        offset = velocidadFondo * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
