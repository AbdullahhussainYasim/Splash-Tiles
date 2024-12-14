using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionscript : MonoBehaviour
{
    public float x = 10f;
    public float y = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(x, y, 0)) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
