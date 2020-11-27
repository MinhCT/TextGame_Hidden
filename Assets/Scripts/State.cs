using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story State")]
public class State : ScriptableObject
{
    [TextArea(20, 24)]
    [SerializeField]
    string storyText;

    [SerializeField]
    State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
