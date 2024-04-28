using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadingScene(string Name)
    {
        StartCoroutine(Loading());

        IEnumerator Loading()
        {
            yield return new WaitForSeconds(0);
            SceneManager.LoadSceneAsync(Name);
        }
    }
}
