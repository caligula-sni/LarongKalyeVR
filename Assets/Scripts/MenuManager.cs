using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsPanel; // Assign in Inspector

    public void StartGame()
    {
        SceneManager.LoadScene("PatinteroScene");
    }

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit requested");
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }
}
