using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPerception : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject _Pawn;
    private Vector3 _checkDirection;
    [SerializeField] private float distance;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void CheckDistance()
    {
        _checkDirection = Player.transform.position - _Pawn.transform.position;
        RaycastHit hit;

        if (Physics.Raycast(_Pawn.transform.position, _checkDirection, out hit, distance))
        {
            if (hit.collider.gameObject.GetComponent<PlayerController>())
            {
                _Pawn.GetComponentInChildren<IA_Controller>().PlayerNear = true;
            } else
            {
                _Pawn.GetComponentInChildren<IA_Controller>().PlayerNear = false;
            }
        }
        else
        {
            _Pawn.GetComponentInChildren<IA_Controller>().PlayerNear = false;
        }
    }
}
