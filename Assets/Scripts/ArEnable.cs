using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArEnable : MonoBehaviour
{
    [SerializeField] private GameObject ArObjects;

    [SerializeField] private GameObject Ui;

    public void EnableAR()
    {
        ArObjects.SetActive(true);
        Ui.SetActive(false);
    }

    public void DisableAR()
    {
        ArObjects.SetActive(false);
        Ui.SetActive(true);
    }
    public void LoadAR(string name)
    {
        StartCoroutine(Loading());

        IEnumerator Loading()
        {
            SceneManager.LoadSceneAsync(name);
            yield return new WaitForSeconds(0);
        }
    }
}
