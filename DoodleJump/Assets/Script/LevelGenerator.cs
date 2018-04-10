using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject jumpBoosterPrefab;
    public GameObject badPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
   
	void Start () {
        Vector3 spawnPosition = new Vector3();
        Instantiate(platformPrefab, new Vector3(0, -2, 0), Quaternion.identity);
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            if(i%11 == 0)
            {
                Instantiate(jumpBoosterPrefab, spawnPosition, Quaternion.identity);
            }else if(i%7 == 0)
            {
                Instantiate(badPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
