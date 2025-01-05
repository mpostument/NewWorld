using UnityEngine;

public class Controller : BaseController
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        movable.MoveTo(new Vector2(x, y));
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movable.SetRun(true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movable.SetRun(false);
        }
    }
}
