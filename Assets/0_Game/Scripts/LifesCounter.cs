using R3;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;
using static UnityEngine.Rendering.VolumeComponent;

public class LifesCounter : MonoBehaviour
{
    [Inject] Player player;
    //[SerializeField] Player player;
    private PlayerHealth health;
    [SerializeField] TMP_Text livesText;
    private CompositeDisposable _disposable = new();


    void Start()

    {
        health = player.gameObject.GetComponent<PlayerHealth>();
        health.OnHealthChangedR3.Subscribe(lives => UpdateHealth(lives)).AddTo(_disposable);
        health.OnHealthEndedR3.Subscribe(_ => EndedHealth()).AddTo(_disposable);
    }

    private void UpdateHealth(int lives)
    {
        print("Событие OnHealthChanged произошло");
        livesText.text = lives.ToString();
    }

    private void EndedHealth()
    {
        print("Событие OnHealthEndedR3 произошло");
        livesText.text = "ПЗДЦ - ты мертв!!!!";
    }

    private void OnDestroy()
    {
        _disposable?.Dispose();
    }
}
