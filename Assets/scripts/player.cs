using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float velocity = 5.0f;
    public float velocityGorizontalDir = 4.0f;
    public int health = 100;
    public FixedJoystick joystick;
    public Text healthCount;

    void Start()
    {
        healthCount = GameObject.Find("healthCount").GetComponent<Text>();
        healthCount.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocity * Time.deltaTime, 0,
            -1*(velocityGorizontalDir * joystick.Direction.x * Time.deltaTime));
    }
    public void uplateHealth (int damage)
    {
        health += damage;
        healthCount.text = health.ToString();
    }
}
