using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            SceneManager.LoadScene("endOfLevel", LoadSceneMode.Single);
        }
    }
}
