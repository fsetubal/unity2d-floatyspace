using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChar : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spriteCharGameOver;
    [SerializeField] private GameObject transitionGameOver;
    [SerializeField] private GameObject panelGameOver;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Limit")
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;

        spriteRenderer.sprite = spriteCharGameOver;
        transitionGameOver.transform.position = transform.position;
        transitionGameOver.SetActive(true);

        StartCoroutine(ShowPanelGameOver());
    }

    private IEnumerator ShowPanelGameOver()
    {
        yield return new WaitForSecondsRealtime(1f);
        panelGameOver.SetActive(true);
    }
}