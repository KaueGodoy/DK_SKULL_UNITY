using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/MoveSpeedBuff")]
public class MoveSpeedBuff : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().speed += amount;
    }
}
