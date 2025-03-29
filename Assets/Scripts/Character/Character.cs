using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
    
{
    [SerializeField]
    private CharacterDate characterDate;

    protected Imoble MovavableComponent;

    public void Start()
    {
        MovavableComponent = new CharacterMovementCompanent();
        MovavableComponent.Initialize(characterDate);
    }
    public abstract void update();
    
}
