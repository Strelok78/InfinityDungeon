using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private const string DeadAnimation = "Dead";
    private const string DefendAnimation = "Defend";
    private const string RunAnimation = "Run";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayDamageAnimation()
    {
        _animator.Play(DefendAnimation);
    }

    public void PlayDeathAnimation()
    {
        _animator.Play(RunAnimation);
    }
}
