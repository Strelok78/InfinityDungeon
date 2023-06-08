using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private UnityEvent _isDead;
    [SerializeField] private UnityEvent _isDamaged;
    [SerializeField] private AudioClip _backgroundSound;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {

        HealthChanged.Invoke(_health);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        _isDamaged.Invoke();
        HealthChanged?.Invoke(_health);

        if (_health <= 0)
            Die();
    }

    public void Die()
    {

        _isDead.Invoke();
        Died?.Invoke();
    }
}
