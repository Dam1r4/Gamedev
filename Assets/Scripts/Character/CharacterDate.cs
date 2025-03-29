using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDate : MonoBehaviour
{
  [SerializeField] private float speed;
  [SerializeField] private Transform characterTransform; 
  [SerializeField] private CharacterController characterController;

    public float DefaultSpeed=>speed;
    public Transform CharacterTransform => characterTransform;
    public CharacterController CharacterController
    {  get { 
            return characterController; 
        } 
    }
}
