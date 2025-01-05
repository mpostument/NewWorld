using UnityEngine;

public abstract class BaseMovable : MonoBehaviour
{
    public Vector2 direction;
    public float runSpeed = 20f;
    public float walkSpeed = 10f;
    
    public abstract void MoveTo(Vector2 direction);
    public abstract void SetRun(bool run);
}
