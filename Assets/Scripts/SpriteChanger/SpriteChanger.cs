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
        // SpriteRenderer bileþenini al
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Belirli aralýklarla "SpriteDegistir" metodunu çaðýr
        InvokeRepeating("SpriteDegistir", 0f, 2f);
    }

    void SpriteDegistir()
    {
        // Þu anki sprite'ý kontrol et ve diðerine geçiþ yap
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
