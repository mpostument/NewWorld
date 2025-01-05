using UnityEngine;

public class EnemyAICircle : BaseController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time);
        float y = Mathf.Sin(Time.time);
        movable.MoveTo(new Vector2(x, y));
    }
}
