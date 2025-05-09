﻿using UnityEngine;
using UnityEditor;

namespace SWFrameWork.Tools.AutoRef
{
    public class AutoRefMonoBehaviour : MonoBehaviour
    {
#if UNITY_EDITOR
        protected virtual void OnValidate()
        {
            if (!EditorApplication.isPlaying)
            {
                this.AutoRefComponents();
            }
        }
#else
        protected virtual void OnValidate() { }
#endif
    }
}