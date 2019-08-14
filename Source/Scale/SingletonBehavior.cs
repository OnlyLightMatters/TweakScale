﻿using TweakScale.Annotations;
using UnityEngine;

namespace TweakScale
{
    internal class SingletonBehavior<T> : MonoBehaviour where T : SingletonBehavior<T>
    {
        public static T Instance { get; protected set; }

        [UsedImplicitly]
        protected void Awake()
        {
            Instance = (T)this;
        }
    }
}