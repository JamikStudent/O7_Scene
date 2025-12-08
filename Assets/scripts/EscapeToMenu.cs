using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
 	else if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("corridor", LoadSceneMode.Single);
        }
	else if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("218", LoadSceneMode.Single);
        }


    }
}