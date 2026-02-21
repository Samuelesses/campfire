using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public int playerCount = 4;

    float minX = -8f;
    float maxX = 8f;
    float minY = -5f;
    float maxY = 5f;
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
