using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour
{
    [SerializeField] private BoxCollider2D attackBox;
    [SerializeField] private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        attackBox.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
            
    }
    void Attack()
    {
        attackBox.enabled = true;
        anime.SetBool("IsAttacking",true);
        Debug.Log("attacked");
    }
    void SAttack()
    {
        attackBox.enabled = false;
        anime.SetBool("IsAttacking",false);
        Debug.Log("Sattacked");
    }
}
