using System;
using System.Collections;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    Coroutine moveCoroutine;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // moveCoroutine = StartCoroutine(MoveCoroutine());
        StartCoroutine(ChangeSpriteColorCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    IEnumerator MoveRightCoroutine()
    {
        Vector2 startPosition = transform.position;

        for (var x = startPosition.x; x < startPosition.x + 10; x += 0.2f)
        {
            transform.position = new Vector2(x, startPosition.y);
            yield return new WaitForFixedUpdate();
        }
    }
    
    IEnumerator MoveLefttCoroutine()
    {
        Vector2 startPosition = transform.position;

        for (var x = startPosition.x; x > startPosition.x - 10; x -= 0.2f)
        {
            transform.position = new Vector2(x, startPosition.y);
            yield return new WaitForFixedUpdate();
        }
    }
    
    IEnumerator MoveTopCoroutine()
    {
        Vector2 startPosition = transform.position;

        for (var y = startPosition.y; y < startPosition.y + 10; y += 0.2f)
        {
            transform.position = new Vector2(startPosition.x, y);
            yield return new WaitForFixedUpdate();
        }
    }
    
    IEnumerator MoveDownCoroutine()
    {
        Vector2 startPosition = transform.position;

        for (var y = startPosition.y; y > startPosition.y - 10; y -= 0.2f)
        {
            transform.position = new Vector2(startPosition.x, y);
            yield return new WaitForFixedUpdate();
        }
    }
    
    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            yield return MoveRightCoroutine();
            yield return MoveTopCoroutine();
            yield return MoveLefttCoroutine();
            yield return MoveDownCoroutine();
        }
    }

    IEnumerator ChangeSpriteColorCoroutine()
    {
        float changeInterval = 0.5f;
        float endTime = 5f;
        float currentTime = 0f;
        
        while (currentTime < endTime)
        {
            currentTime += changeInterval;
            spriteRenderer.color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
            yield return new WaitForSeconds(changeInterval);
        }
        
    }
}
