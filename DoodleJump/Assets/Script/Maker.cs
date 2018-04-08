using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour {
    public GameObject car;
    public GameObject other;
    public int numberOfPlatforms = 200;
    float levelWidth = 7f;
    float minY = 3f;
    float maxY = 4.5f;

    void Start () {
        Vector3 platPos = new Vector3();
        for(int i = 0; i < numberOfPlatforms; i++)
        {
            if (i == 0)
            {
                platPos.y = -4.98f;
                platPos.x = 0f;
            }
            platPos.x = Random.Range(-levelWidth, levelWidth);
            platPos.y += Random.Range(minY, maxY);
            if (i%11 == 0)
            {
                Instantiate(other, platPos, Quaternion.identity);

            }
            Instantiate(car, platPos, Quaternion.identity);
        }
    }
}
