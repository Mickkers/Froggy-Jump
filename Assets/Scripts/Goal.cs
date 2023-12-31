using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    [SerializeField] private string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            StartCoroutine(NextScene());
        }
    }

    private IEnumerator NextScene()
    {
        if (nextScene.Equals(""))
        {
            Debug.LogWarning("No Next Scene");
        }
        else
        {
            yield return new WaitForSecondsRealtime(.5f);
            SceneManager.LoadScene(nextScene);
        }
    }
}
