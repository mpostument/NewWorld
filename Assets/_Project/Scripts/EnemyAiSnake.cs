using UnityEngine;

public class EnemyAiSnake : BaseController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Time.time;
        float y = Mathf.Sin(Time.time * 2); // Adjust the frequency as needed
        movable.MoveTo(new Vector2(x, y));
    }
}
