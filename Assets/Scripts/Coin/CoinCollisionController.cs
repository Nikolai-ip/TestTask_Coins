using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CoinCollisionController : MonoBehaviour
{
    [SerializeField] UnityEvent onPlayerTriggerCoinEnter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerInput player))
        {
            onPlayerTriggerCoinEnter?.Invoke();
            Destroy(gameObject);
        }
       
    }
}
