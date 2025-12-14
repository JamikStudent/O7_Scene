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
            SceneManager.LoadScene("216", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene("218", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("4"))
        {
            SceneManager.LoadScene("256", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene("257", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("6"))
        {
            SceneManager.LoadScene("257а", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("7"))
        {
            SceneManager.LoadScene("258", LoadSceneMode.Single);
        }
else if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene("260", LoadSceneMode.Single);
        }



    }
}