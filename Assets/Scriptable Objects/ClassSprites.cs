using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Class Sprites")]
public class ClassSprites : ScriptableObject
{
    [Header("---Scout Red---")]
    public Sprite[] redScouts;
    [Header("---Scout Blue---")]
    public Sprite[] blueScouts;

    [Space(15)]

    [Header("---Soldier Red---")]
    public Sprite[] redSoldier;
    [Header("---Soldier Blue---")]
    public Sprite[] blueSoldier;

    [Space(15)]

    [Header("---Pyro Red")]
    public Sprite[] redPyro;
    [Header("---Pyro Blue---")]
    public Sprite[] bluePyro;

    [Space(15)]

    [Header("---Demoman Red---")]
    public Sprite[] redDemo;
    [Header("---Demoman Blue---")]
    public Sprite[] blueDemo;

    [Space(15)]

    [Header("---Heavy Red---")]
    public Sprite[] redHeavy;
    [Header("---Heavy Blue---")]
    public Sprite[] blueHeavy;

    [Space(15)]

    [Header("---Engineer Red---")]
    public Sprite[] redEngi;
    [Header("---Engineer Blue---")]
    public Sprite[] blueEngi;

    [Space(15)]

    [Header("---Medic Red---")]
    public Sprite[] redMedic;
    [Header("---Medic Blue---")]
    public Sprite[] blueMedic;

    [Space(15)]

    [Header("---Sniper Red---")]
    public Sprite[] redSniper;
    [Header("---Sniper Blue---")]
    public Sprite[] blueSniper;

    [Space(15)]

    [Header("---Spy Red---")]
    public Sprite[] redSpy;
    [Header("---Spy Blue---")]
    public Sprite[] blueSpy;
}
