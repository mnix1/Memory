using System.Collections.Generic;
using UnityEngine;

public class Back
{
    public static List<Back> BACKS = new List<Back> {
            new Back("tulips"),
        };

    string name;

    public Back(string name)
    {
        this.name = name;
    }

    public Sprite Load()
    {
        return Resources.Load<Sprite>("Backs/" + name);
    }
}
