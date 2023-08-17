﻿using DG.Tweening;
using System;
using UnityEngine;

namespace NCL.Framework
{
    public class AutoDestructObject : MonoCached
    {
        [Header("Config")]
        [SerializeField] float _delay = 0f;
        [SerializeField] bool _deactiveOnly = false;

        Tween _tween;

        public event Action eventDestruct;

        #region MonoBehaviour

        void OnEnable()
        {
            _tween?.Kill();
            _tween = DOVirtual.DelayedCall(_delay, Destruct);
        }

        void OnDisable()
        {
            _tween?.Kill();
        }

        void OnDestroy()
        {
            _tween?.Kill();
        }

        #endregion

        void Destruct()
        {
            if (_deactiveOnly)
                gameObjectCached.SetActive(false);
            else
                Destroy(gameObjectCached);

            eventDestruct?.Invoke();
        }
    }
}