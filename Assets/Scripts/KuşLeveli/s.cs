using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s : MonoBehaviour
{
    public Transform targetObject; // Bağlamak istediğiniz game object'in Transform bileşeni

    void Update()
    {
        // Ana karakterin rotasyonunu game objecte bağla
        targetObject.rotation = transform.rotation;
    }
}
