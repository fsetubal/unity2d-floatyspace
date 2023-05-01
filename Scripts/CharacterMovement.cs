using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite spriteCharacterFreeze;
    [SerializeField] private Sprite spriteCharacterMoving;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 150);

            spriteRenderer.sprite = spriteCharacterMoving;

            StopAllCoroutines();
            StartCoroutine(ChangeToFreezeSprite());

        }
    }

    private IEnumerator ChangeToFreezeSprite()
    {
        yield return new WaitForSeconds(1.0f);
        spriteRenderer.sprite = spriteCharacterFreeze;
    }
}
