using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoMovimiento_Player : MonoBehaviour
{
    [SerializeField] private Transform personaje; // Referencia al objeto del personaje
    [SerializeField] private Vector2 factorMovimiento; // Factor para ajustar la velocidad del fondo

    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        // Calcula el offset basado únicamente en la posición X del personaje
        offset = new Vector2(personaje.position.x * factorMovimiento.x, 0);
        material.mainTextureOffset = offset;
    }
}