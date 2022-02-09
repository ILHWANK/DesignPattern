using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Target' class
/// </summary>
public interface INewAvtion
{
    void EventMove(Transform tr);
    void EventStop(Transform tr);
}