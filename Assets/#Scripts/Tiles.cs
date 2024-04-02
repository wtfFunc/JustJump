using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tiles : MonoBehaviour
{
    [Range(0.01f,1f)]
    public float FrictionForce;




    public virtual void PlayerRanding()
    {

    }

    public virtual void PlayerStay()
    {
    
    }

    public virtual void PlayerTakeOff()
    {

    }



}
