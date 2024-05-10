using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("home");
    }
    public void level1()
    {
        SceneManager.LoadScene("level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("level2");
    }
}
