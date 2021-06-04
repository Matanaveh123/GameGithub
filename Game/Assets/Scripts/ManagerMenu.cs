using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    [SerializeField] int timeToWait;
    private void Start()
    {
        StartCoroutine("LoadMenu");
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(timeToWait);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.buildIndex + 1);
    }

}
