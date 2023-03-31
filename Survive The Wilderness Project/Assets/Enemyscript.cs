using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public float Speed;
    public EnemySpawner _EnemySpawner;

    // Start is called before the first frame update
    void Start()
    {
        _EnemySpawner = FindObjectOfType<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        transform.position = _EnemySpawner.RandomSpawningPosition();
    }
}
