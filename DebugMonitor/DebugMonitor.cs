﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// MiYALABで公開しているC#用ライブラリです。
/// </summary>
namespace MiYALAB.CSharp
{
    /// <summary>
    /// デバッグモニタを表示するフォームクラスです。
    /// </summary>
    public partial class DebugMonitor : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox textBoxDebug;

        /// <summary>
        /// デバッグモニタを表示するフォームクラスです。
        /// </summary>
        public DebugMonitor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// デバッグモニタを表示するフォームクラスです。
        /// </summary>
        /// <param name="positionX">変更後のウインドウのx座標</param>
        /// <param name="positionY">変更後のウインドウのy座標</param>
        public DebugMonitor(int positionX, int positionY)
        {
            InitializeComponent();

            MoveWindow(positionX, positionY);
        }

        /// <summary>
        /// デバッグモニタを表示するフォームクラスです。
        /// </summary>
        /// <param name="positionX">変更後のウインドウのx座標</param>
        /// <param name="positionY">変更後のウインドウのy座標</param>
        /// <param name="sizeX">変更後のウインドウの幅</param>
        /// <param name="sizeY">変更後のウインドウの高さ</param>
        public DebugMonitor(int positionX, int positionY, int sizeX, int sizeY)
        {
            InitializeComponent();
            
            MoveWindow(positionX, positionY);
            ChangeWindowSize(sizeX, sizeY);
        }

        /// <summary>
        /// デザイナーで自動作成されたコード
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(12, 12);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDebug.Size = new System.Drawing.Size(260, 237);
            this.textBoxDebug.TabIndex = 0;
            // 
            // DebugMonitor
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxDebug);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugMonitor";
            this.Text = "デバッグモニタ";
            this.SizeChanged += new System.EventHandler(this.DebugMonitor_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// フォームサイズ変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebugMonitor_SizeChanged(object sender, EventArgs e)
        {
            this.textBoxDebug.Size = new System.Drawing.Size(this.ClientSize.Width - 24, this.ClientSize.Height - 24);
        }

        /// <summary>
        /// デバッグモニタのサイズを変更します。
        /// </summary>
        /// <param name="x">変更後のウインドウの幅</param>
        /// <param name="y">変更後のウインドウの高さ</param>
        public void ChangeWindowSize(int x, int y)
        {
            this.Size = new System.Drawing.Size(x, y);
        }

        /// <summary>
        /// デバッグモニタの表示位置を変更します。
        /// </summary>
        /// <param name="x">変更後のウインドウのx座標</param>
        /// <param name="y">変更後のウインドウのy座標</param>
        public void MoveWindow(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
        }

        /// <summary>
        /// デバッグモニタにテキストを挿入します。
        /// </summary>
        /// <param name="text">挿入テキスト</param>
        public void Write(string text)
        {
            this.textBoxDebug.AppendText(text);
        }

        /// <summary>
        /// デバッグモニタに改行付きでテキストを挿入します。
        /// </summary>
        /// <param name="text">挿入テキスト</param>
        public void WriteLine(string text)
        {
            this.textBoxDebug.AppendText(text + Environment.NewLine);
        }
    }
}