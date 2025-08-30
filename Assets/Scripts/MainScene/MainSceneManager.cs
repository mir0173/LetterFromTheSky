using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainSceneManager : MonoBehaviour
{
    private int key;
    public CanvasGroup fadeimg;
    public CanvasGroup textcanvas;
    public CanvasGroup choosecanvas;
    public TextMeshProUGUI choose;
    public TextMeshProUGUI choose1;
    public TextMeshProUGUI choose2;
    private int textindex;
    void Awake()
    {
        textindex = 0;
        key = 0;
        choose.text = "";
        choose1.text = "";
        choose2.text = "";
        textcanvas.blocksRaycasts = false;
        choosecanvas.blocksRaycasts = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        fadeimg.DOFade(0, 2)
        .OnComplete(() =>
        {
            fadeimg.blocksRaycasts = false;
            textcanvas.DOFade(1, 1)
            .OnComplete(() =>
            {
                textcanvas.blocksRaycasts = true;
                StartCoroutine(MainScriptManager.PrintScript(textindex++));     
            });
        });   
    }
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        if (key == 0 && textindex < 12 && Input.GetMouseButtonUp(0) && MainScriptManager.isCantalk)
        {
            StartCoroutine(MainScriptManager.PrintScript(textindex++));
        }
        else if (key == 0 && textindex == 12 && Input.GetMouseButtonUp(0) && MainScriptManager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScriptManager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 1)
        {
            choose.text = "당신은 갈림길에 도착했고 첫 번째 선택의 시간이 다가왔다";
            choose1.text = "왼쪽으로 가기(맑음)";
            choose2.text = "오른쪽으로 가기(구름)";
            choosecanvas.blocksRaycasts = true;
            choosecanvas.DOFade(1, 2)
            .OnComplete(() =>
            {
            });
            if (MouseOnUI.isMouseOver && choosecanvas.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 11;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene2");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 14;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene2");
                    });
                }
            }
        }
           
    }
}
