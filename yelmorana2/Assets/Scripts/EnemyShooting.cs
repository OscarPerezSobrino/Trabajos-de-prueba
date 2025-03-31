using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    public float shotingRange = 8;
    public float timeBetweenShots = 1;

    private Animator anim; // Agregar referencia al Animator

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>(); // Obtener el componente Animator
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance); //para saber a qué distancia está

        if (distance < shotingRange)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenShots)
            {
                timer = 0;
                // Activar animación de ataque antes de disparar
                anim.SetBool("Atacando", true); // Usa un Trigger si prefieres
                Shoot();
            }
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
