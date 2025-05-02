using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonController : MonoBehaviour
{
    public void onClickStart() {
        SceneManager.LoadScene("main");
    }
    public void onClickExit() {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }
}
