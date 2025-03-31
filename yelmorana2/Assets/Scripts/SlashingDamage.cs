using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashingDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "meleedano")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
