using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move pipes left
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        // Destroy pipes off screen
        if (transform.position.x < -25f)
        {
            Destroy(gameObject);
        }
    }
}
