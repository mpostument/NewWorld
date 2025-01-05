using UnityEngine;

public abstract class BaseMovable : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 10f;
    
    public abstract void MoveTo(Vector2 direction);
    public abstract void SetRun(bool run);
}
