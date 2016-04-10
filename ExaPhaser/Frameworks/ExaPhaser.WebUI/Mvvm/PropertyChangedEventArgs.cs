﻿using System;

namespace ExaPhaser.WebUI.Mvvm
{
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs args);

    public class PropertyChangedEventArgs : EventArgs
    {
        public string PropertyName { get; private set; }

        public PropertyChangedEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}