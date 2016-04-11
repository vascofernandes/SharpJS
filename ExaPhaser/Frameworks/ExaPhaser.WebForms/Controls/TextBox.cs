﻿using System;
using JSIL.Dom.Elements;

namespace ExaPhaser.WebForms.Controls
{
    public class TextBox : TextControl
    {
        #region Public Constructors

        public TextBox() : base()
        {
            InternalElement = new InputElement()
            {
                Type = "text",
            };
            InternalElement.Change += OnTextChanged;
            InternalJQElement.EnterKeyPressed += OnEnterPressed;
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler EnterPressed;

        public event EventHandler TextChanged;

        #endregion Public Events

        #region Public Properties

        public string Text
        {
            get { return GetText(); } //We are using GetText because the text
            set { SetText(value); }
        }

        public InputType TextInputType
        {
            get { return GetInputType(); }
            set { SetInputType(value); }
        }

        #endregion Public Properties

        #region Public Methods

        public override void PerformLayout()
        {
            base.PerformLayout();
        }

        #endregion Public Methods

        #region Private Methods

        private InputType GetInputType()
        {
            switch (InternalElement["type"])
            {
                case "text":
                    return InputType.Text;

                case "password":
                    return InputType.Password;

                case "email":
                    return InputType.Email;

                case "number":
                    return InputType.Number;

                case "search":
                    return InputType.Search;

                default:
                    return InputType.Text;
            }
        }

        private string GetText()
        {
            return InternalElement["value"];
        }

        private void OnEnterPressed(object sender, EventArgs e)
        {
            EventHandler handler = EnterPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            EventHandler handler = TextChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void SetInputType(InputType value)
        {
            switch (value)
            {
                case InputType.Text:
                    InternalElement["type"] = "text";
                    break;

                case InputType.Password:
                    InternalElement["type"] = "password";
                    break;

                case InputType.Email:
                    InternalElement["type"] = "email";
                    break;

                case InputType.Number:
                    InternalElement["type"] = "number";
                    break;

                case InputType.Search:
                    InternalElement["type"] = "search";
                    break;
            }
        }

        private void SetText(string value)
        {
            InternalElement["value"] = value;
        }

        #endregion Private Methods
    }
}