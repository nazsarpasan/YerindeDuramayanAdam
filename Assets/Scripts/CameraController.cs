using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sabitYukseklik = 5.0f;

    void LateUpdate()
    {
        Vector3 yeniKonum = transform.position;
        yeniKonum.y = sabitYukseklik;
        transform.position = yeniKonum;
    }
}