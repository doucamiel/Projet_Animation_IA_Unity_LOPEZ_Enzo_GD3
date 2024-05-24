using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public enum IAState
{
    None,
    Idle,
    Patrol,
    PlayersSeen,
    PlayerNear,
}

public class IA_Controller : MonoBehaviour
{
    private IAState _state = IAState.None;
    [SerializeField] private Animator _animator;
    public bool PlayerNear = false;
    public bool PlayerSeen = false;
    public bool PlayerPatrol = false;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private GameObject _waypoint;

    private void Update()
    {
        CheckTransition();
        Behavior();
    }

    private void Behavior()
    {
        switch (_state)
        {
            case IAState.None:
                //
                //
                break;
            case IAState.Idle:
                //
                //
                break;
            case IAState.Patrol:
                //
                //
                break;
            case IAState.PlayersSeen:
                //
                //
                break;
            case IAState.PlayerNear:
                //
                //
                break;
        }
    }

    private void CheckTransition()
    {
        switch (_state)
        {
            case IAState.None:
                break;
            case IAState.Idle:
                if (PlayerNear)
                {
                    _state = IAState.PlayerNear;
                    _animator.SetBool("PlayerIsNear", true);

                }
                break;
            case IAState.Patrol:
                if (PlayerNear)
                {
                    _state = IAState.PlayerNear;
                    _animator.SetBool("PlayerIsNear", true);

                }
                break;
            case IAState.PlayersSeen:
                if (PlayerNear)
                {
                    _state = IAState.PlayerNear;
                    _animator.SetBool("PlayerIsNear", true);

                }
                break;
            case IAState.PlayerNear:
                if (!PlayerNear)
                {
                    _state = IAState.Patrol;
                    _animator.SetBool("PlayerIsNear", false);

                }
                break;
        }
    }
}