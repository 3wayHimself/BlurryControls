﻿using System.Windows;
using BlurryControls.Controls;
using BlurryControls.Helpers;
using BlurryControls.Internals;

namespace BlurryControls.DialogFactory
{
    /// <summary>
    /// Provides a variety of overloads for displaying a simple <see cref="BlurryDialogWindow"/> 
    /// to show a prompt or information
    /// </summary>
    public static class BlurryMessageBox
    {
        #region Conventional Content Dialogs

        /// <summary>
        /// Displays a message box that has a message; and returns a result.
        /// </summary>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string messageBoxText, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = string.Empty,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = BlurryDialogButton.Ok,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box that has a message and title bar caption; and returns a result.
        /// </summary>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string messageBoxText, string caption, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = BlurryDialogButton.Ok,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string messageBoxText, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = string.Empty,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = BlurryDialogButton.Ok,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box that has a message, title bar caption and button;
        /// and returns a result.
        /// </summary>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string messageBoxText, string caption, BlurryDialogButton button, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = button,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message, title bar caption; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string messageBoxText, string caption, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = BlurryDialogButton.Ok,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box that has a message, title bar caption, button, and icon;
        /// and returns a result.
        /// </summary>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="icon">A <see cref="BlurryDialogIcon"/> value that specifies the icon to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string messageBoxText, string caption, BlurryDialogButton button, BlurryDialogIcon icon, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = icon,
                DialogMessage = messageBoxText,
                Button = button,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message, title bar caption and button; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string messageBoxText, string caption, BlurryDialogButton button, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                Button = button,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message, title bar caption, button, and icon; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="icon">A <see cref="BlurryDialogIcon"/> value that specifies the icon to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string messageBoxText, string caption, BlurryDialogButton button, BlurryDialogIcon icon, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = icon,
                DialogMessage = messageBoxText,
                Button = button,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        #endregion

        #region Custom Content Dialogs

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string caption, FrameworkElement content, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                Button = BlurryDialogButton.Ok,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string caption, FrameworkElement content, BlurryDialogButton button, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                Button = button,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="customDialogButtons"> A <see cref="ButtonCollection"/> shown instead of the conventional dialog buttons.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string messageBoxText, string caption, ButtonCollection customDialogButtons, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                CustomDialogButtons = customDialogButtons,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="customDialogButtons"> A <see cref="ButtonCollection"/> shown instead of the conventional dialog buttons.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(string caption, FrameworkElement content, ButtonCollection customDialogButtons, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                CustomDialogButtons = customDialogButtons,
                Owner = null,
                Strength = strength ?? ColorHelper.GetStrength()
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string caption, FrameworkElement content, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                Button = BlurryDialogButton.Ok,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="button">A <see cref="BlurryDialogButton"/> value that specifies which button or buttons to display.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string caption, FrameworkElement content, BlurryDialogButton button, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                Button = button,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A <see cref="string"/> that specifies the text to display.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="customDialogButtons"> A <see cref="ButtonCollection"/> shown instead of the conventional dialog buttons.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string messageBoxText, string caption, ButtonCollection customDialogButtons, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                DialogMessage = messageBoxText,
                CustomDialogButtons = customDialogButtons,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays
        /// a message; and returns a result.
        /// </summary>
        /// <param name="owner">A <see cref="Window"/> that represents the owner window of the message box.</param>
        /// <param name="caption">A <see cref="string"/> that specifies the title bar caption to display.</param>
        /// <param name="content">A <see cref="FrameworkElement"/> that specifies the content to display.</param>
        /// <param name="customDialogButtons"> A <see cref="ButtonCollection"/> shown instead of the conventional dialog buttons.</param>
        /// <param name="strength"> Determines the opacity of the window which is set to 0.75 by default and may not exceed 1</param>
        /// <returns>A <see cref="BlurryDialogResult"/> value that specifies which message box button is clicked by the user.</returns>
        public static BlurryDialogResult Show(Window owner, string caption, FrameworkElement content, ButtonCollection customDialogButtons, double? strength = null)
        {
            var result = BlurryDialogResult.None;
            var dialog = new BlurryDialogWindow
            {
                Title = caption,
                DialogIcon = BlurryDialogIcon.None,
                CustomContent = content,
                CustomDialogButtons = customDialogButtons,
                Owner = owner,
                Strength = strength ?? ColorHelper.GetStrength(owner)
            };

            dialog.ResultAquired += (sender, args) =>
            {
                dialog.Close();
                result = args.Result;
            };

            dialog.ShowDialog();

            return result;
        }

        #endregion
    }
}