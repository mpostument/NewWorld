using System.Collections;
using UnityEngine;

public class EnemyAiFire : BaseController
{
    Vector2 _pointA;
    Vector2 _pointB;
    float _threshold = 0.1f;
    
    void Start()
    {
        _pointA = transform.position;
        _pointB = new Vector2(transform.position.x + 5, transform.position.y + 1);
        StartCoroutine(MoveToAndBack());
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    IEnumerator MoveToPoint(Vector2 target)
    {
        while (Vector2.Distance(transform.position, target) > _threshold)
        {
            Debug.Log(target);
            Vector2 direction = (target - (Vector2)transform.position).normalized;
            movable.MoveTo(direction);
            yield return new WaitForFixedUpdate();
        }
        movable.MoveTo(Vector2.zero);
    }
    
    IEnumerator MoveToAndBack()
    {
        while (true)
        {
            yield return MoveToPoint(_pointB);
            yield return new WaitForSeconds(1f);
            yield return MoveToPoint(_pointA);
            Debug.Log(_pointA);
            yield return new WaitForSeconds(1f);
        }
    }
}
