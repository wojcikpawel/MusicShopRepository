namespace MusicShopUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.purchasedAlbumsListboxLabel = new System.Windows.Forms.Label();
            this.purchasedAlbumsListboxTest = new System.Windows.Forms.ListBox();
            this.zletowarzystwoPictureBox = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.playlistListBoxLabel = new System.Windows.Forms.Label();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.zletowarzystwoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "<- Back To Music Shop";
            this.button1.UseVisualStyleBackColor = true;
           // this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchasedAlbumsListboxLabel
            // 
            this.purchasedAlbumsListboxLabel.AutoSize = true;
            this.purchasedAlbumsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchasedAlbumsListboxLabel.Location = new System.Drawing.Point(27, 200);
            this.purchasedAlbumsListboxLabel.Name = "purchasedAlbumsListboxLabel";
            this.purchasedAlbumsListboxLabel.Size = new System.Drawing.Size(158, 20);
            this.purchasedAlbumsListboxLabel.TabIndex = 16;
            this.purchasedAlbumsListboxLabel.Text = "Purchased Albums";
            // 
            // purchasedAlbumsListboxTest
            // 
            this.purchasedAlbumsListboxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchasedAlbumsListboxTest.FormattingEnabled = true;
            this.purchasedAlbumsListboxTest.ItemHeight = 20;
            this.purchasedAlbumsListboxTest.Location = new System.Drawing.Point(31, 222);
            this.purchasedAlbumsListboxTest.Margin = new System.Windows.Forms.Padding(2);
            this.purchasedAlbumsListboxTest.Name = "purchasedAlbumsListboxTest";
            this.purchasedAlbumsListboxTest.Size = new System.Drawing.Size(333, 324);
            this.purchasedAlbumsListboxTest.TabIndex = 15;
            //this.purchasedAlbumsListboxTest.SelectedIndexChanged += new System.EventHandler(this.purchasedAlbumsListboxTest_SelectedIndexChanged);
            // 
            // zletowarzystwoPictureBox
            // 
            this.zletowarzystwoPictureBox.Image = global::MusicShopUI.Properties.Resources.zle_towarzystwo;
            this.zletowarzystwoPictureBox.Location = new System.Drawing.Point(415, 222);
            this.zletowarzystwoPictureBox.Name = "zletowarzystwoPictureBox";
            this.zletowarzystwoPictureBox.Size = new System.Drawing.Size(412, 327);
            this.zletowarzystwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zletowarzystwoPictureBox.TabIndex = 26;
            this.zletowarzystwoPictureBox.TabStop = false;
            this.zletowarzystwoPictureBox.Visible = false;
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop.Location = new System.Drawing.Point(1124, 496);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(138, 50);
            this.stop.TabIndex = 30;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.Location = new System.Drawing.Point(892, 496);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(138, 50);
            this.play.TabIndex = 29;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            // 
            // playlistListBoxLabel
            // 
            this.playlistListBoxLabel.AutoSize = true;
            this.playlistListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistListBoxLabel.Location = new System.Drawing.Point(888, 200);
            this.playlistListBoxLabel.Name = "playlistListBoxLabel";
            this.playlistListBoxLabel.Size = new System.Drawing.Size(65, 20);
            this.playlistListBoxLabel.TabIndex = 28;
            this.playlistListBoxLabel.Text = "Playlist";
            // 
            // playlistListBox
            // 
            this.playlistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.ItemHeight = 20;
            this.playlistListBox.Location = new System.Drawing.Point(892, 222);
            this.playlistListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(370, 264);
            this.playlistListBox.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.playlistListBoxLabel);
            this.Controls.Add(this.playlistListBox);
            this.Controls.Add(this.zletowarzystwoPictureBox);
            this.Controls.Add(this.purchasedAlbumsListboxLabel);
            this.Controls.Add(this.purchasedAlbumsListboxTest);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Your Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.zletowarzystwoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label purchasedAlbumsListboxLabel;
        public System.Windows.Forms.ListBox purchasedAlbumsListboxTest;
        private System.Windows.Forms.PictureBox zletowarzystwoPictureBox;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label playlistListBoxLabel;
        private System.Windows.Forms.ListBox playlistListBox;
    }
}