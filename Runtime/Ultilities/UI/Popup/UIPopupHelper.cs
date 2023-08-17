﻿using System;
using UnityEngine;

namespace NCL.Framework
{
    public static class UIPopupHelper
    {
        public static Transform popupRoot;

        public static T Create<T>(GameObject prefab) where T : UIPopupBehaviour
        {
            if (popupRoot == null)
                popupRoot = GameObject.FindObjectOfType<Canvas>().transform;

            T popup = prefab.Create(popupRoot, false).GetComponent<T>();
            popup.transform.SetAsLastSibling();

            return popup;
        }

        public static UIPopupBehaviour Create(GameObject prefab)
        {
            return Create<UIPopupBehaviour>(prefab);
        }

        public static UIPopupConfirm CreateConfirm(GameObject prefab, string header, string content, Action<bool> onConfirm)
        {
            UIPopupConfirm popup = Create<UIPopupConfirm>(prefab);
            popup.Construct(header, content, onConfirm);

            return popup;
        }

        public static UIPopupMessage CreateMessage(GameObject prefab, string msg)
        {
            UIPopupMessage popup = Create<UIPopupMessage>(prefab);
            popup.Construct(msg);

            return popup;
        }
    }
}