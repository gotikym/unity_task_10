using UnityEngine;

public class ProgressBar : Bar
{
    [SerializeField] private Spawner _spawner;    

    private void OnEnable()
    {
        _spawner.EnemyCountChanged += OnValueChanged;
        Slider.value = StartVolue;
    }

    private void OnDisable()
    {
        _spawner.EnemyCountChanged -= OnValueChanged;
    }
}
