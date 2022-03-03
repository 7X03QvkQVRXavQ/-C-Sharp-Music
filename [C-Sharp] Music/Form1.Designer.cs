namespace _C_Sharp__Music
{
    partial class PlayerWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerWindow));
            this.Songs = new System.Windows.Forms.ListBox();
            this.volumeDown_button = new System.Windows.Forms.Button();
            this.volumeUp_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.playPause_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Songs
            // 
            this.Songs.FormattingEnabled = true;
            this.Songs.ItemHeight = 16;
            this.Songs.Location = new System.Drawing.Point(12, 71);
            this.Songs.Margin = new System.Windows.Forms.Padding(4);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(314, 244);
            this.Songs.TabIndex = 0;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            // 
            // volumeDown_button
            // 
            this.volumeDown_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.volumeDown_button;
            this.volumeDown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeDown_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeDown_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeDown_button.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeDown_button.Location = new System.Drawing.Point(301, 39);
            this.volumeDown_button.Name = "volumeDown_button";
            this.volumeDown_button.Size = new System.Drawing.Size(25, 25);
            this.volumeDown_button.TabIndex = 8;
            this.volumeDown_button.UseVisualStyleBackColor = true;
            this.volumeDown_button.Click += new System.EventHandler(this.volumeDown_button_Click);
            this.volumeDown_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeDown_button_MouseDown);
            this.volumeDown_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeDown_button_MouseUp);
            // 
            // volumeUp_button
            // 
            this.volumeUp_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.volumeUp_button;
            this.volumeUp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeUp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeUp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeUp_button.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeUp_button.Location = new System.Drawing.Point(301, 13);
            this.volumeUp_button.Name = "volumeUp_button";
            this.volumeUp_button.Size = new System.Drawing.Size(25, 25);
            this.volumeUp_button.TabIndex = 7;
            this.volumeUp_button.UseVisualStyleBackColor = true;
            this.volumeUp_button.Click += new System.EventHandler(this.volumeUp_button_Click);
            this.volumeUp_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeUp_button_MouseDown);
            this.volumeUp_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeUp_button_MouseUp);
            // 
            // stop_button
            // 
            this.stop_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.stop_button;
            this.stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_button.ForeColor = System.Drawing.SystemColors.Control;
            this.stop_button.Location = new System.Drawing.Point(128, 13);
            this.stop_button.Margin = new System.Windows.Forms.Padding(4);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(50, 50);
            this.stop_button.TabIndex = 6;
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            this.stop_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stop_button_MouseDown);
            this.stop_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stop_button_MouseUp);
            // 
            // next_button
            // 
            this.next_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.next_button;
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.ForeColor = System.Drawing.SystemColors.Control;
            this.next_button.Location = new System.Drawing.Point(186, 13);
            this.next_button.Margin = new System.Windows.Forms.Padding(4);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(50, 50);
            this.next_button.TabIndex = 5;
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            this.next_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.next_button_MouseDown);
            this.next_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.next_button_MouseUp);
            // 
            // previous_button
            // 
            this.previous_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.prew_button;
            this.previous_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_button.ForeColor = System.Drawing.SystemColors.Control;
            this.previous_button.Location = new System.Drawing.Point(12, 13);
            this.previous_button.Margin = new System.Windows.Forms.Padding(4);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(50, 50);
            this.previous_button.TabIndex = 4;
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            this.previous_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previous_button_MouseDown);
            this.previous_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previous_button_MouseUp);
            // 
            // playPause_button
            // 
            this.playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.play_button;
            this.playPause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPause_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPause_button.ForeColor = System.Drawing.SystemColors.Control;
            this.playPause_button.Location = new System.Drawing.Point(70, 13);
            this.playPause_button.Margin = new System.Windows.Forms.Padding(4);
            this.playPause_button.Name = "playPause_button";
            this.playPause_button.Size = new System.Drawing.Size(50, 50);
            this.playPause_button.TabIndex = 2;
            this.playPause_button.UseVisualStyleBackColor = true;
            this.playPause_button.Click += new System.EventHandler(this.playPause_button_Click);
            this.playPause_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playPause_button_MouseDown);
            this.playPause_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playPause_button_MouseUp);
            // 
            // import_button
            // 
            this.import_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.import_button;
            this.import_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.import_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_button.ForeColor = System.Drawing.SystemColors.Control;
            this.import_button.Location = new System.Drawing.Point(244, 13);
            this.import_button.Margin = new System.Windows.Forms.Padding(4);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(50, 50);
            this.import_button.TabIndex = 1;
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            this.import_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.import_button_MouseDown);
            this.import_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.import_button_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 325);
            this.Controls.Add(this.volumeDown_button);
            this.Controls.Add(this.volumeUp_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.playPause_button);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.Songs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(356, 376);
            this.Name = "Form1";
            this.Text = "SUPER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button playPause_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button volumeUp_button;
        private System.Windows.Forms.Button volumeDown_button;
    }
}
