using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float velocity = 5.0f;
    public float velocityGorizontalDir = 4.0f;
    public int health = 100;
    public Text healthCount;

    void Start()
    {
        healthCount = GameObject.Find("healthCount").GetComponent<Text>();
        healthCount.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, velocity * Time.deltaTime);
    }
    public void uplateHealth (int damage)
    {
        health += damage;
        healthCount.text = health.ToString();
    }
     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Orb"))
        {
            Debug.Log("blyat");
        }
    }
}
