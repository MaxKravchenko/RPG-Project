using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;

        private void Update() 
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (GetIsChase(player))
            {
                Debug.Log(transform.name + " shoud chase Player");
            }
            
        }

        private bool GetIsChase(GameObject target)
        {
            return Vector3.Distance(transform.position, target.transform.position) <= chaseDistance;
        }
    }
}
