using UnityEngine;
using TMPro;
using System.Collections;
using System;
public class Timer: MonoBehaviour {

    [SerializeField] private TMP_Text _text;
    private float _currentTime;
    public GameObject loseScreen;
    void Start()
    {
        _currentTime = 45.0f;
    }

    void Update(){

        _currentTime -= Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(_currentTime);
        _text.text = time.Minutes.ToString() + ":" + time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
        if (_currentTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        Time.timeScale = 0;
        loseScreen.SetActive(true);
    }
}
