using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainScene3Manager : MonoBehaviour
{
    private int key;
    private int setkey;
    public Image background;
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;
    public Sprite bg4;
    public CanvasGroup fadeimg;
    public CanvasGroup textcanvas;
    public CanvasGroup choosecanvas1;
    public TextMeshProUGUI choose1;
    public TextMeshProUGUI choose11;
    public CanvasGroup choosecanvas2;
    public TextMeshProUGUI choose2;
    public TextMeshProUGUI choose21;
    public TextMeshProUGUI choose22;
    private int textindex;
    void Awake()
    {
        textindex = 0;
        setkey = PlayerPrefs.GetInt("key");
        if (setkey == 21)
        {
            background.sprite = bg1;
        }
        else if (setkey == 22)
        {
            background.sprite = bg2;
        }
        else if (setkey == 24)
        {
            background.sprite = bg3;
        }
        else if (setkey == 25)
        {
            background.sprite = bg4;
        }
        key = 0;
        choose1.text = "";
        choose11.text = "";
        choose2.text = "";
        choose21.text = "";
        choose21.text = "";
        textcanvas.blocksRaycasts = false;
        choosecanvas1.blocksRaycasts = false;
        choosecanvas2.blocksRaycasts = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        fadeimg.DOFade(0, 2)
        .OnComplete(() =>
        {
            fadeimg.blocksRaycasts = false;
            textcanvas.DOFade(1, 1)
            .OnComplete(() =>
            {
                textcanvas.blocksRaycasts = true;
                if (setkey == 21)
                {
                    StartCoroutine(MainScript3Manager.PrintScript21(textindex++));     
                }
                else if (setkey == 22)
                {
                    StartCoroutine(MainScript3Manager.PrintScript22(textindex++));     
                }
                else if (setkey == 24)
                {
                    StartCoroutine(MainScript3Manager.PrintScript24(textindex++));     
                }
                else if (setkey == 25)
                {
                    StartCoroutine(MainScript3Manager.PrintScript25(textindex++));     
                }
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
        if (key == 0 && setkey == 21 && textindex < 8 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            StartCoroutine(MainScript3Manager.PrintScript21(textindex++));
        }
        else if (key == 0 && setkey == 21 && textindex == 8 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript3Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 22 && textindex < 9 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            StartCoroutine(MainScript3Manager.PrintScript21(textindex++));
        }
        else if (key == 0 && setkey == 22 && textindex == 9 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript3Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 24 && textindex < 7 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            StartCoroutine(MainScript3Manager.PrintScript21(textindex++));
        }
        else if (key == 0 && setkey == 24 && textindex == 7 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript3Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 0 && setkey == 25 && textindex < 9 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            StartCoroutine(MainScript3Manager.PrintScript21(textindex++));
        }
        else if (key == 0 && setkey == 25 && textindex == 9 && Input.GetMouseButtonUp(0) && MainScript3Manager.isCantalk)
        {
            textcanvas.DOFade(0, 1)
            .OnComplete(() =>
            {
                MainScript3Manager.script.text = "";
                textcanvas.blocksRaycasts = false;
                key = 1;
            });
        }
        if (key == 1 && setkey == 21)
        {
            choose1.text = "당신은 계속 맑은 길로 나아간다.";
            choose11.text = "앞으로 나아가기(맑음)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 31;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene4");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 22)
        {
            choose2.text = "당신은 갈림길에 도착했고 세 번째 선택의 시간이 다가왔다";
            choose21.text = "왼쪽으로 가기(맑음)";
            choose22.text = "오른쪽으로 가기(안개)";
            choosecanvas2.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas2.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas2.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 31;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene3");
                    });
                }
                if (MouseOnUI.gameObj.name == "script2" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                   .OnComplete(() =>
                   {
                       key = 33;
                       PlayerPrefs.SetInt("key", key);
                       PlayerPrefs.Save();
                       SceneManager.LoadScene("MainScene3");
                   });
                }
            }
        }
        else if (key == 1 && setkey == 24)
        {
            choose1.text = "당신은 계속 구름 낀 길로 나아간다.";
            choose11.text = "앞으로 나아가기(구름)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 34;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene4");
                    });
                }
            }
        }
        else if (key == 1 && setkey == 25)
        {
            choose1.text = "당신은 계속 비가 내리는 길로 나아간다.";
            choose11.text = "앞으로 나아가기(비)";
            choosecanvas1.DOFade(1, 2)
            .OnComplete(() =>
            {
                choosecanvas1.blocksRaycasts = true;
            });
            if (MouseOnUI.isMouseOver && choosecanvas1.blocksRaycasts == true)
            {
                if (MouseOnUI.gameObj.name == "script1" && Input.GetMouseButtonDown(0))
                {
                    fadeimg.DOFade(1, 2)
                    .OnComplete(() =>
                    {
                        key = 35;
                        PlayerPrefs.SetInt("key", key);
                        PlayerPrefs.Save();
                        SceneManager.LoadScene("MainScene4");
                    });
                }
            }
        }

    }
}
