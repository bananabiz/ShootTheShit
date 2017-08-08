using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables
{
    public class Movement : MonoBehaviour
    {

        public float movementSpeed = 20f;
        public float rotationSpeed = 20f;
        public Vector3 rotateDir = Vector3.forward;

        void Start()
        {

            float inputH = Input.GetAxis("Horizonal");
            float inputV = Input.GetAxis("Vertical");
            transform.position += transform.right * inputV * movementSpeed * Time.deltaTime;
            transform.eulerAngles += -rotateDir * inputH * rotationSpeed * Time.deltaTime;

        }
    }
}