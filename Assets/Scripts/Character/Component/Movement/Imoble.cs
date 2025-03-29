using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Imoble 
{
    public float Speed {  get; set; }

    public void Initialize(CharacterDate characterDate);

    public void Move(Vector3 direction);

    public void Rotation(Vector3 direction);
}
