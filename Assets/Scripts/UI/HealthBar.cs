using UnityEngine;

public class HealthBar : Bar
{
    [SerializeField] private Player _palyer;

    private void OnEnable()
    {
        _palyer.HealthChanged += OnValueChanged;
        Slider.value = StartVolue;
    }

    private void OnDisable()
    {
        _palyer.HealthChanged -= OnValueChanged;     
    }
}
