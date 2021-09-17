//Found from https://forum.unity.com/threads/ui-inverse-mask.342324/ post by nicloay
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class InvertedMaskImage : Image
{
    public override Material materialForRendering
    {
        get
        {
            Material result = base.materialForRendering;
            result.SetInt("_StencilComp", (int)CompareFunction.NotEqual);
            return result;
        }
    }
}