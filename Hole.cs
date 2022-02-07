using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hole : MonoBehaviour
{
    enum State { Playing, Dead, NextLevel };
    State state = State.Playing;
    private void Start()
    {
        state = State.Playing;
    }
    void LoadNextLevel()
    {
        int currentLevelindex = SceneManager.GetActiveScene().buildIndex;
        int nextLevelindex = currentLevelindex + 1;
        if (nextLevelindex == SceneManager.sceneCountInBuildSettings)
        {
            nextLevelindex = 1;
        }

        SceneManager.LoadScene(nextLevelindex);
    }
    void LoadFirstLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snakemain"))
        {
                
            SceneManager.LoadScene(3);
        }

    }   
}
