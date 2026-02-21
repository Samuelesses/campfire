using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public int playerCount = 4;

    float minX = -7f;
    float maxX = 7f;
    float minY = -4f;
    float maxY = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlayers()
    {
        for (int i = 0; i < playerCount; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector2 spawnPosition = new Vector2(randomX, randomY);
            Instantiate(playerPrefab, spawnPosition, Quaternion.identity, transform);
        }
    }
}
