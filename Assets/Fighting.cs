using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _bc;
    [SerializeField] private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        
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
        anime.SetBool("IsAttacking",true);
        Debug.Log("Attacked");
    }
    void SAttack()
    {
        anime.SetBool("IsAttacking",false);
    }
}
