using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipesprefab;
    float randomHeight = 15f;
    
   void SpawnPipes()
   {
       Instantiate(pipesprefab, new Vector2(-15, Random.Range(11, 18)), Quaternion.identity);
   }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
