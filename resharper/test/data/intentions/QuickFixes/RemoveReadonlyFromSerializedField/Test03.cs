// ${RUN:2}
using System;
using UnityEngine;

public class Test
{
    [Serialize{caret}Field] public readonly int Value1, Value2, Value3;
}
