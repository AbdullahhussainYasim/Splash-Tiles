using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyerscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
