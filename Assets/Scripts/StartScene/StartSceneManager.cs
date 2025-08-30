using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class StartSceneManager : MonoBehaviour
{
    private bool key;
    private bool Isexp;
    private bool Isexping;
    private bool Isrec;
    private bool Isrecoding;
    private bool Cond;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public TextMeshProUGUI text5;
    public TextMeshProUGUI text6;
    public CanvasGroup fadeimg;
    public CanvasGroup expcanvas;
    public CanvasGroup recordcanvas;
    void Awake()
    {
        text1.alpha = 0.5f;
        text2.alpha = 0.5f;
        text3.alpha = 0.5f;
        text4.alpha = 0.5f;
        text5.alpha = 0.5f;
        text6.alpha = 0.5f;
        PlayerPrefs.SetInt("key", 0);
        PlayerPrefs.SetInt("take1", 0);
        PlayerPrefs.Save();
        if (!PlayerPrefs.HasKey("Ending1"))
        {
            PlayerPrefs.SetInt("Ending1", 0);
            PlayerPrefs.SetInt("Ending2", 0);
            PlayerPrefs.SetInt("Ending3", 0);
            PlayerPrefs.SetInt("Ending4", 0);
            PlayerPrefs.SetInt("Ending5", 0);
            PlayerPrefs.SetInt("Ending6", 0);
            PlayerPrefs.Save();
        }
        Cond = false;
        Isexp = false;
        Isexping = false;
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        expcanvas.blocksRaycasts = false;
        recordcanvas.blocksRaycasts = false;
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
        if (PlayerPrefs.GetInt("Ending1") == 1)
        {
            text1.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending2") == 1)
        {
            text2.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending3") == 1)
        {
            text3.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending4") == 1)
        {
            text4.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending5") == 1)
        {
            text5.alpha = 1;
        }
        if (PlayerPrefs.GetInt("Ending6") == 1)
        {
            text6.alpha = 1;
        }
        if (!Isexp && !Isexping && !Isrec && !Isrecoding)
        {
            Cond = true;
        }
        else
        {
            Cond = false;
        }
        if (Isexp && Input.GetKeyDown(KeyCode.Escape))
        {
            Isexp = false;
            Isexping = true;
            expcanvas.DOFade(0, 0.5f)
            .OnComplete(() =>
            {
                Isexping = false;
                expcanvas.blocksRaycasts = false;
            });
        }
        if (Isrec && Input.GetKeyDown(KeyCode.Escape))
        {
            Isrec = false;
            Isrecoding = true;
            recordcanvas.DOFade(0, 0.5f)
            .OnComplete(() =>
            {
                Isrecoding = false;
                recordcanvas.blocksRaycasts = false;
            });
        }
        if (MouseOnUI.isMouseOver)
        {
            if (MouseOnUI.gameObj.name == "Startgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    SceneManager.LoadScene("MainScene");
                }
            }
            if (MouseOnUI.gameObj.name == "Recordgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                    Isrec = true;
                    Isrecoding = true;
                    recordcanvas.DOFade(1, 0.5f)
                    .OnComplete(() =>
                    {
                        Isrecoding = false;
                        recordcanvas.blocksRaycasts = true;
                    });
                }
            }
            if (MouseOnUI.gameObj.name == "Expgame" && Cond)
            {
                MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                key = true;
                if (Input.GetMouseButtonDown(0))
                {
                                        Isexp = true;
                    Isexping = true;
                    expcanvas.DOFade(1, 0.5f)
                    .OnComplete(() =>
                    {
                        Isexping = false;
                        expcanvas.blocksRaycasts = true;
                    });
                }
            }
            if (MouseOnUI.gameObj.name == "Endgame" && Cond)
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
            if (Isrec)
            {
                Debug.Log(MouseOnUI.gameObj.name);
                if (MouseOnUI.gameObj.name == "Text1" && PlayerPrefs.GetInt("Ending1") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text1.text = "희망";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text1.text = "맑음";
                }
                if (MouseOnUI.gameObj.name == "Text2" && PlayerPrefs.GetInt("Ending2") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text2.text = "무기력";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text2.text = "구름";
                }
                if (MouseOnUI.gameObj.name == "Text3" && PlayerPrefs.GetInt("Ending3") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text3.text = "변화";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text3.text = "바람";
                }
                if (MouseOnUI.gameObj.name == "Text4" && PlayerPrefs.GetInt("Ending4") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text4.text = "슬픔";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text4.text = "비";
                }
                if (MouseOnUI.gameObj.name == "Text5" && PlayerPrefs.GetInt("Ending5") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text5.text = "고독";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text5.text = "눈";
                }
                if (MouseOnUI.gameObj.name == "Text6" && PlayerPrefs.GetInt("Ending6") == 1)
                {
                    MouseOnUI.gameObj.transform.DOScale(1.15f, 0.5f);
                    text6.text = "망각";
                    key = true;
                }
                else
                {
                    MouseOnUI.gameObj.transform.DOScale(1f, 0.5f);
                    text6.text = "안개";
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
