using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wisie
{
    public static List<Wisie> WISIES = new List<Wisie> {
            new Wisie("alligator"),
            new Wisie("aurochs"),
            new Wisie("camel"),
            new Wisie("catBlue"),
            new Wisie("catTeacher"),
            new Wisie("catPresenter"),
            new Wisie("crocodile"),
            new Wisie("dog"),
            new Wisie("dogFat"),
            new Wisie("dogSweet"),
            new Wisie("dragon"),
            new Wisie("dragonBlue"),
            new Wisie("dragonFat"),
            new Wisie("dragonRed"),
            new Wisie("eagle"),
            new Wisie("elephant"),
            new Wisie("fox"),
            new Wisie("foxMan"),
            new Wisie("giraffe"),
            new Wisie("gorilla"),
            new Wisie("horse"),
            new Wisie("kangaroo"),
            new Wisie("lampard"),
            new Wisie("lion"),
            new Wisie("octopus"),
            new Wisie("ostrich"),
            new Wisie("owl"),
            new Wisie("pandaEat"),
            new Wisie("parrot"),
            new Wisie("rabbit"),
            new Wisie("raccoonBrown"),
            new Wisie("sheep"),
            new Wisie("snake"),
            new Wisie("squirrel"),
            new Wisie("tiger"),
            new Wisie("turkey"),
            new Wisie("wolf"),
            new Wisie("worm"),
        };

    string name;

    public Wisie(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public Sprite Load()
    {
        return Resources.Load<Sprite>("Wisies/" + name);
    }
}
