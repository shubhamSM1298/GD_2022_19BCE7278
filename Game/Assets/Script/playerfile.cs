using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerfile : MonoBehaviour
{
    bool dead = false;
    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {

            Die();



        }
    }
    void Die()
    {


        Invoke(nameof(ReloadLevel), 1f);
        dead = true;
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
