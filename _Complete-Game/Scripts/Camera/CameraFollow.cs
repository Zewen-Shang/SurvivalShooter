using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float smoothing = 5f;
        Vector3 offect;
        void Start ()
        {
            offect = transform.position - target.position;
        }


        void FixedUpdate ()
        {
            transform.position = Vector3.Lerp(transform.position,target.position + offect,smoothing*Time.deltaTime);
        }
    }
}