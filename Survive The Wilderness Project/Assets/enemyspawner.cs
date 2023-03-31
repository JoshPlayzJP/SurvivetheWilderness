using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemyprefab;
    public float SpawningRange;
    
    public  static bool IsGameActivate;

    public Vector3 RandomSpawningPosition()
    {
     float xPos = Random.Range(transform.position.x -SpawningRange,transform.position.x+SpawningRange);
     float zPos = Random.Range(transform.position.z -SpawningRange,transform.position.z+SpawningRange);

      Vector3 spawningPos = new Vector3(xPos,transform.position.y, zPos);

      return spawningPos;
    }

    // Start is called before the first frame updatea
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Space)&&IsGameActivate==false)
        {
           
                IsGameActivate=true;

           Instantiate(Enemyprefab,RandomSpawningPosition(),transform.rotation);
           Instantiate(Enemyprefab,RandomSpawningPosition(),transform.rotation);
           Instantiate(Enemyprefab,RandomSpawningPosition(),transform.rotation);
           Instantiate(Enemyprefab,RandomSpawningPosition(),transform.rotation);
           Instantiate(Enemyprefab,RandomSpawningPosition(),transform.rotation);
        }
    }
}
