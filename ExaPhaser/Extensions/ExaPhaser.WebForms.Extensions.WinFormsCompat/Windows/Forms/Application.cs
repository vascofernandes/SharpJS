﻿using System.Collections.Generic;
using System.Drawing;
using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Themes;
using SharpJS.Dom;
using SharpJS.Dom.Elements;
using SharpJS.JSLibraries.JQuery;

namespace System.Windows.Forms
{
    public class Application
    {
        #region Private Fields

        private static Dictionary<WebForm, DivElement> _forms = new Dictionary<WebForm, DivElement>();
        private static CSSUITheme _theme = new CSSUITheme(CSSFramework.Kubism);

        #endregion Private Fields

        #region Public Properties

        public static string HostElementId { get; set; } = "webform-container";

        #endregion Public Properties

        #region Public Methods

        [WebFormsCompatStubOnly]
        public static void EnableVisualStyles() { }

        public static void Run(Form form)
        {
            ShowNewForm(form);
        }

        [WebFormsCompatStubOnly]
        public static void SetCompatibleTextRenderingDefault(bool defaultValue) { }

        public static void SetCSSUITheme(CSSUITheme theme)
        {
            _theme = theme;
        }

        internal static void CloseForm(Form formToClose)
        {
            var fWebForm = formToClose.UnderlyingWebForm;
            var divHost = _forms[fWebForm];
            _forms.Remove(fWebForm);
            formToClose.UnderlyingWebForm.InternalJQElement.Remove();
            var hostElement = Document.GetElementById(HostElementId);
            hostElement.RemoveChild(divHost);
        }

        /// <summary>
        /// Creates and adds another newForm to the page.
        /// </summary>
        /// <param name="newForm"></param>
        internal static void ShowNewForm(Form newForm)
        {
            WebApplication sharpJSApp = new WebApplication(_theme);
            var hostElement = Document.GetElementById(HostElementId);
            var newFormHost = new DivElement();
            var jqMainFormHost = new JQElement(newFormHost);
            hostElement.AppendChild(newFormHost);
            var newWebForm = newForm.UnderlyingWebForm;
            newWebForm.InternalJQElement.Css("position", "relative"); //To allow child control positioning
            _forms.Add(newWebForm, newFormHost);
            sharpJSApp.Run(newWebForm, jqMainFormHost);
            InitializeWinFormWFStyles(newWebForm);
            InitializeWebUIElement(newForm);
        }

        private static void InitializeWebUIElement(Form newForm)
        {
            //Add a close button
            var closeButton = new Button { Text = "x", Location = new Point(5, 5)};
            closeButton.Click += (s, e) => CloseForm(newForm);
            newForm.Controls.Add(closeButton);
            newForm.OnInitialized();
            var halfWidth = Document.ClientWidth/2;
            var halfHeight = Document.ClientHeight/2;
            var newFormHalfWidth = newForm.Size.Width/2;
            var newFormHalfHeight = newForm.Size.Height/2;
            newForm.Location = new Point(halfWidth-newFormHalfWidth, halfHeight-newFormHalfHeight); //Center the form
            newForm.Focus();
        }

        private static void InitializeWinFormWFStyles(WebForm mainWebForm)
        {
            mainWebForm.InternalJQElement.AddClass("winform");
            mainWebForm.InternalJQElement.Draggable();
        }

        #endregion Public Methods
    }
}