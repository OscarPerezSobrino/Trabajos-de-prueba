using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSlashing : MonoBehaviour
{
    public GameObject meleArea;
    public float attackDuration = 0.2f; // Tiempo que permanecer� activa el �rea de ataque
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        meleArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetBool("Slash", true); // Activa la animaci�n de ataque
        meleArea.SetActive(true);
        Invoke("DeactivateMeleeArea", attackDuration);
    }

    void DeactivateMeleeArea()
    {
        anim.SetBool("Slash", false); // Desactiva la animaci�n
        meleArea.SetActive(false);
    }
}
