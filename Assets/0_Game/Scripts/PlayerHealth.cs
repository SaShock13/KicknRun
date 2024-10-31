using R3;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int lives = 10;
    public readonly Subject<int> OnHealthChangedR3 = new();
    public readonly Subject<Unit> OnHealthEndedR3 = new();
    private CompositeDisposable _disp = new();


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //TimerTick();
            //IntervalTick();
            //EveryUpdateTick();
        }
    }


    public void TakeDeath()
    {
        Debug.Log("dsdfsdfsdf");
        print("Игрок Погиб!!!");
    }

    private void TimerTick()
    {
        Observable
            .Timer(TimeSpan.FromSeconds(2f))
            .Subscribe(_ => DecreaseLifes())
            .AddTo(_disp);
    }

    private void IntervalTick()
    {
        Observable
            .Interval(TimeSpan.FromSeconds(2f))
            .Subscribe(_ => DecreaseLifes())
            .AddTo(_disp);
    }
    private void EveryUpdateTick()
    {
        Observable
            .EveryUpdate()
            .Subscribe(_ => DecreaseLifes())
            .AddTo(_disp);
    }

    public void DecreaseLifes()
    {
        lives--;
        OnHealthChangedR3.OnNext(lives);
        if (lives <= -1000)
        {
            OnHealthEndedR3.OnNext(Unit.Default);
            OnHealthChangedR3.OnCompleted();
        }
        if (lives <= 0) OnHealthChangedR3.OnCompleted();

    }
}
