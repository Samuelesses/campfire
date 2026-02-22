using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class AbilitySpawner : MonoBehaviour
{

    public GameObject orbPrefab;
    public float spawnRate = 10f;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public Canvas winScreen;
    public TextMeshProUGUI winnerText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnOrb", 2f, spawnRate);
    }

    void Update()
    {
        GameObject[] remainingPlayers = GameObject.FindGameObjectsWithTag("Player");
        {
            if (remainingPlayers.Length <= 1)
            {
                
                winScreen.gameObject.SetActive(true);
                if (remainingPlayers.Length == 1)
                {
                    winnerText.text = remainingPlayers[0].GetComponent<PlayerController>().nameText.text + " Wins!";
                    Time.timeScale = 0f;
                }
                else
                {
                    winnerText.text = "Tie!";
                    Time.timeScale = 0f;
                }
                
            }
        }
    }

    // Update is called once per frame
    void SpawnOrb()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPos = new Vector2(randomX, randomY);

        GameObject newOrb = Instantiate(orbPrefab, spawnPos, Quaternion.identity);
        UpdatePlayerTargetLists();
    }

    void UpdatePlayerTargetLists()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        
        foreach (GameObject player in allPlayers)
        {
            PlayerController pc = player.GetComponent<PlayerController>();
            pc.abilityOrb = GameObject.FindGameObjectsWithTag("Ability");
            
        }
    }
}
