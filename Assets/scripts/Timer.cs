using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{// ref = https://youtu.be/POq1i8FyRyQ?si=-RRkzPlJHiR0bTBG
    //ref = https://docs.unity3d.com/ScriptReference/Time.html

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float startTime = 30f; 
    private float currentTime;

    void Start()
    {
        currentTime = startTime;
        UpdateTimerUI();
    }

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                currentTime = 0f;
                 SceneManager.LoadScene("death");
            }

            UpdateTimerUI();
        }
    }

    private void UpdateTimerUI()
    {
        timerText.text = currentTime.ToString("F2");
    }
}
