using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class StartSceneManager : MonoBehaviour
{
    private bool key;
    public CanvasGroup fadeimg;
    void Awake()
    {

        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        fadeimg.DOFade(0, 2)
        .OnComplete(() =>
        {
            fadeimg.blocksRaycasts = false;
        });
        
    }
    void Start()
    {

    }

    void Update()
    {
        if (MouseOnUI.isMouseOver)
        {
            if (MouseOnUI.gameObj.name == "Startgame")
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    SceneManager.LoadScene("MainScene");
                }
            }
            if (MouseOnUI.gameObj.name == "Expgame")
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                
            }
            if (MouseOnUI.gameObj.name == "Endgame")
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();
#endif
                }
            }

        }
        else if (key == true)
        {
            if (MouseOnUI.gameObj != null) MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
            key = false;
        }
    }
}
