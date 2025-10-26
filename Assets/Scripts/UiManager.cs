using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UiManager : MonoBehaviour
{

    public Image timerImage;
    public TMP_Text bottomText;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Reset the timer
        GameManager.instance.ResetTimer();

        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        UpdateScore();
    }

    void UpdateTimer()
    {
        GameManager.instance.timeRemaining -= Time.deltaTime;
        timerImage.fillAmount = GameManager.instance.timeRemaining / GameManager.instance.maxTime;
    }

    void UpdateScore()
    {
        bottomText.text= "Score:" + GameManager.instance.score;
    }
}
