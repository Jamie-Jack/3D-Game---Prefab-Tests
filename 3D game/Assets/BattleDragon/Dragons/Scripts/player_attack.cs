using UnityEngine;
using System.Collections;

public class player_attack : MonoBehaviour
{
    private Animator anim; 

    // Use this for initialization
    void Awake()
    {
        // Set up references.
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // Attack
        if (Input.GetButtonDown("J"))
        {
            anim.SetTrigger("Attack_1");
            return;
        }

        // dead
        if (Input.GetButtonDown("1"))
        {
            anim.SetTrigger("Dead");
            return;
        }

        // damage
        if (Input.GetButtonDown("2"))
        {
            anim.SetTrigger("Damage");
            return;
        }

        // burst
        if (Input.GetButtonDown("3"))
        {
            anim.SetTrigger("Burst");
            return;
        }

        // defense
        if (Input.GetButtonDown("4"))
        {
            anim.SetTrigger("Defense");
            return;
        }
    }
}
