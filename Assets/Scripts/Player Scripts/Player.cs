using UnityEngine;
using System.Collections;

public class Player
{
    private PlayerStats _playerStatistics;

    public PlayerStats PlayerStatistics
    {
        get { return _playerStatistics; }
        set { _playerStatistics = value; }
    }

    private Attributes _playerAttributes;

    public Attributes PlayerAttributes
    {
        get { return _playerAttributes; }
        set { _playerAttributes = value; }
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
