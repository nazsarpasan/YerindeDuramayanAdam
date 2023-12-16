using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // SpriteRenderer bile�enini al
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Belirli aral�klarla "SpriteDegistir" metodunu �a��r
        InvokeRepeating("SpriteDegistir", 0f, 2f);
    }

    void SpriteDegistir()
    {
        // �u anki sprite'� kontrol et ve di�erine ge�i� yap
        if (spriteRenderer.sprite == sprite1)
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1;
        }
    }
}
