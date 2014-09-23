using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
    // how much damage you can take before it ends
    public int Health;
    public int MaxHealth;
    // energy will be used to sneak around/abilities
    public int Energy;
    public int MaxEnergy;
    // how fast you move
    public float WalkSpeed;
    public float RunSpeed;
    public float TurnSpeed;
}
