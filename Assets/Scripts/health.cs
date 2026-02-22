using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int totalHp;

    public bool isShielded = false;
    [SerializeField] GameObject damDisplay;
    private Slider hpSlider;


    void Start()
    {
        hpSlider = GetComponentInChildren<Slider>();
        hpSlider.maxValue = totalHp;
        hpSlider.value = totalHp;
    }

    public void takeDamage(int incomingMin, int incomingMax)
    {
        if (isShielded)
        {
            return;
        }

        int damage = Random.Range(incomingMin, incomingMax);
        totalHp -= damage;

        hpSlider.value = totalHp;

        if (totalHp <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(damDisplay, transform.position, transform.rotation)
                .GetComponent<damNumScript>().updateText("-" + damage);
        }
    }
}