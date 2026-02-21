using UnityEngine;

public class UISwitch : MonoBehaviour
{
    public GameObject NoPlayers;
    public GameObject Players;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Players.SetActive(true);
            NoPlayers.SetActive(false);
        }
    }
}
