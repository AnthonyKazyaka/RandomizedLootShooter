using UnityEngine;
using System.Collections;

public class Attributes
{
    private int _level;

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    private float _health;

    public float Health
    {
        get { return _health; }
        set { _health = value; }
    }

    private float _armor;

    public float Armor
    {
        get { return _armor; }
        set { _armor = value; }
    }

    private float _agility;

    public float Agility
    {
        get { return _agility; }
        set { _agility = value; }
    }

    private float _accuracy;

    public float Accuracy
    {
        get { return _accuracy; }
        set { _accuracy = value; }
    }

    private float _luck;

    public float Luck
    {
        get { return _luck; }
        set { _luck = value; }
    }

    private float _strength;

    public float Strength
    {
        get { return _strength; }
        set { _strength = value; }
    }

}
