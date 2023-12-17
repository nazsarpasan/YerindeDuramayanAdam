using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class simit : MonoBehaviour
{

    [SerializeField] GameObject[] SimitPrefeb;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float MinTransX;
    [SerializeField] float MaxTransX;
    [SerializeField] float MinTransY;
    [SerializeField] float MaxTransY;

    [SerializeField] Transform kus;
    void Start()
    {
        StartCoroutine(SimitSpawn());
    }
    IEnumerator SimitSpawn()
    {
        while (true)
        {
            var wanted = kus.position.x + Random.Range(MinTransX, MaxTransX);
            var wantedy = kus.position.y + Random.Range(MinTransY, MaxTransY);
            var postion = new Vector3(wanted, wantedy);
            GameObject gameObject = Instantiate(SimitPrefeb[Random.Range(0,SimitPrefeb.Length)],
                postion, Quaternion.identity);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }

    }
  

}

