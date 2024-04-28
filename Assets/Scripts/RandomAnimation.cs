using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();    
    }

    private void OnMouseDown()
    {
        int randomInt = Random.Range(1, 10);

        animator.SetInteger("animIndex", randomInt);

        Invoke("ResetAnimIndex", 2);
    }

    public void ResetAnimIndex()
    {
        animator.SetInteger("animIndex", 0);
    }
}
