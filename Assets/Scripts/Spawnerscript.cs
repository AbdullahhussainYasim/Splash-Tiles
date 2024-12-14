using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public float x = 10f;
    public float y = 5f;
    public GameObject tiles;
    public float delay = 0.1f;
    public float mini = 6.3f;
    public float maxi = 9f;

    private List<Transform> childPositions = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {

        foreach (Transform child in transform)
        {
            childPositions.Add(child);
        }

        spawnuntill();
    }


    void spawner()
    {
        foreach (Transform child in transform)
        {
            GameObject tile = Instantiate(tiles, child.position, Quaternion.identity);
            tile.transform.parent = child;
        }
    }

    bool isempty()
    {
        foreach (Transform child in transform)
        {
            if (child.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }

    void spawnuntill()
    {
        ShufflePositions(); 

        Transform position = freeposition();
        float random = Random.Range(mini, maxi);
        Vector3 offset = new Vector3(0, random, 0);

        if (position)
        {
            GameObject tile = Instantiate(tiles, position.transform.position + offset, Quaternion.identity);
            tile.transform.parent = position;
        }

        if (freeposition())
        {
            Invoke("spawnuntill", delay);
        }
    }

    Transform freeposition()
    {
        foreach (Transform child in childPositions)
        {
            if (child.childCount == 0)
            {
                return child;
            }
        }
        return null;
    }


    void ShufflePositions()
    {
        for (int i = 0; i < childPositions.Count; i++)
        {
            int randomIndex = Random.Range(0, childPositions.Count);
            Transform temp = childPositions[i];
            childPositions[i] = childPositions[randomIndex];
            childPositions[randomIndex] = temp;
        }
    }


    void Update()
    {
        if (isempty())
        {
            spawnuntill();
        }
    }
}
