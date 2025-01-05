using UnityEngine;

public abstract class BaseAnimator : MonoBehaviour
{
    protected Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
}
