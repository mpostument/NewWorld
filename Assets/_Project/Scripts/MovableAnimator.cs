using UnityEngine;

public class MovableAnimator : BaseAnimator
{
    public BaseMovable movable;
    const string HORIZONTAL = "Horizontal";
    const string VERTICAL = "Vertical";
    const string SPEED = "Speed";
    
    void Update()
    {
        float speed = movable.direction.magnitude;

        if (speed > 0)
        {
            animator.SetFloat(HORIZONTAL, movable.direction.x);
            animator.SetFloat(VERTICAL, movable.direction.y);
        }
        animator.SetFloat(SPEED, speed);
    }
}
