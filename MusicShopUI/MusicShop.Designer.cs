namespace MusicShopUI
{
    partial class MusicShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicShop));
            this.headerText = new System.Windows.Forms.Label();
            this.albumsListbox = new System.Windows.Forms.ListBox();
            this.albumsListboxLabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.artistListboxLabel = new System.Windows.Forms.Label();
            this.artistsListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.backToStore = new System.Windows.Forms.Button();
            this.purchasedAlbumsListboxLabel = new System.Windows.Forms.Label();
            this.purchasedAlbumsListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.playlistListBoxLabel = new System.Windows.Forms.Label();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.buttonCreatePDF = new System.Windows.Forms.Button();
            this.interstellarPictureBox = new System.Windows.Forms.PictureBox();
            this.plasticBeachPictureBox = new System.Windows.Forms.PictureBox();
            this.zletowarzystwoPictureBox = new System.Windows.Forms.PictureBox();
            this.monochromyPictureBox = new System.Windows.Forms.PictureBox();
            this.younghemsPictureBox = new System.Windows.Forms.PictureBox();
            this.trojkatwarszawskiPictureBox = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interstellarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticBeachPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zletowarzystwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monochromyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.younghemsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trojkatwarszawskiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerText.Location = new System.Drawing.Point(589, 9);
            this.headerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(194, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Music Shop";
            // 
            // albumsListbox
            // 
            this.albumsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.albumsListbox.FormattingEnabled = true;
            this.albumsListbox.ItemHeight = 20;
            this.albumsListbox.Location = new System.Drawing.Point(22, 89);
            this.albumsListbox.Margin = new System.Windows.Forms.Padding(2);
            this.albumsListbox.Name = "albumsListbox";
            this.albumsListbox.Size = new System.Drawing.Size(333, 204);
            this.albumsListbox.TabIndex = 1;
            // 
            // albumsListboxLabel
            // 
            this.albumsListboxLabel.AutoSize = true;
            this.albumsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.albumsListboxLabel.Location = new System.Drawing.Point(18, 67);
            this.albumsListboxLabel.Name = "albumsListboxLabel";
            this.albumsListboxLabel.Size = new System.Drawing.Size(117, 20);
            this.albumsListboxLabel.TabIndex = 2;
            this.albumsListboxLabel.Text = "Store Albums";
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddToCart.Location = new System.Drawing.Point(393, 107);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(138, 50);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add ->";
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(555, 67);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(124, 20);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(559, 89);
            this.shoppingCartListbox.Margin = new System.Windows.Forms.Padding(2);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(333, 204);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.BackColor = System.Drawing.Color.LightGreen;
            this.makePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makePurchase.Location = new System.Drawing.Point(754, 298);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(138, 50);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Buy Now";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // artistListboxLabel
            // 
            this.artistListboxLabel.AutoSize = true;
            this.artistListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artistListboxLabel.Location = new System.Drawing.Point(936, 67);
            this.artistListboxLabel.Name = "artistListboxLabel";
            this.artistListboxLabel.Size = new System.Drawing.Size(61, 20);
            this.artistListboxLabel.TabIndex = 8;
            this.artistListboxLabel.Text = "Artists";
            // 
            // artistsListbox
            // 
            this.artistsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artistsListbox.FormattingEnabled = true;
            this.artistsListbox.ItemHeight = 20;
            this.artistsListbox.Location = new System.Drawing.Point(940, 89);
            this.artistsListbox.Margin = new System.Windows.Forms.Padding(2);
            this.artistsListbox.Name = "artistsListbox";
            this.artistsListbox.Size = new System.Drawing.Size(370, 204);
            this.artistsListbox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeProfitLabel.Location = new System.Drawing.Point(1016, 313);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(111, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit: ";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeProfitValue.Location = new System.Drawing.Point(1123, 313);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(82, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "0,00 PLN";
            // 
            // backToStore
            // 
            this.backToStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backToStore.Location = new System.Drawing.Point(393, 163);
            this.backToStore.Name = "backToStore";
            this.backToStore.Size = new System.Drawing.Size(138, 50);
            this.backToStore.TabIndex = 11;
            this.backToStore.Text = "<- Back";
            this.backToStore.UseVisualStyleBackColor = false;
            this.backToStore.Click += new System.EventHandler(this.BackToStore_Click);
            // 
            // purchasedAlbumsListboxLabel
            // 
            this.purchasedAlbumsListboxLabel.AutoSize = true;
            this.purchasedAlbumsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchasedAlbumsListboxLabel.Location = new System.Drawing.Point(18, 348);
            this.purchasedAlbumsListboxLabel.Name = "purchasedAlbumsListboxLabel";
            this.purchasedAlbumsListboxLabel.Size = new System.Drawing.Size(158, 20);
            this.purchasedAlbumsListboxLabel.TabIndex = 14;
            this.purchasedAlbumsListboxLabel.Text = "Purchased Albums";
            // 
            // purchasedAlbumsListbox
            // 
            this.purchasedAlbumsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchasedAlbumsListbox.FormattingEnabled = true;
            this.purchasedAlbumsListbox.ItemHeight = 20;
            this.purchasedAlbumsListbox.Location = new System.Drawing.Point(22, 370);
            this.purchasedAlbumsListbox.Margin = new System.Windows.Forms.Padding(2);
            this.purchasedAlbumsListbox.Name = "purchasedAlbumsListbox";
            this.purchasedAlbumsListbox.Size = new System.Drawing.Size(333, 164);
            this.purchasedAlbumsListbox.TabIndex = 13;
            this.purchasedAlbumsListbox.SelectedIndexChanged += new System.EventHandler(this.purchasedAlbumsListbox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // playlistListBoxLabel
            // 
            this.playlistListBoxLabel.AutoSize = true;
            this.playlistListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistListBoxLabel.Location = new System.Drawing.Point(936, 348);
            this.playlistListBoxLabel.Name = "playlistListBoxLabel";
            this.playlistListBoxLabel.Size = new System.Drawing.Size(65, 20);
            this.playlistListBoxLabel.TabIndex = 19;
            this.playlistListBoxLabel.Text = "Playlist";
            // 
            // playlistListBox
            // 
            this.playlistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.ItemHeight = 20;
            this.playlistListBox.Location = new System.Drawing.Point(940, 370);
            this.playlistListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(403, 264);
            this.playlistListBox.TabIndex = 18;
            // 
            // buttonCreatePDF
            // 
            this.buttonCreatePDF.BackColor = System.Drawing.Color.Gray;
            this.buttonCreatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreatePDF.Location = new System.Drawing.Point(393, 219);
            this.buttonCreatePDF.Name = "buttonCreatePDF";
            this.buttonCreatePDF.Size = new System.Drawing.Size(138, 50);
            this.buttonCreatePDF.TabIndex = 26;
            this.buttonCreatePDF.Text = "Export .pdf";
            this.buttonCreatePDF.UseVisualStyleBackColor = false;
            this.buttonCreatePDF.Click += new System.EventHandler(this.buttonCreatePDF_Click);
            // 
            // interstellarPictureBox
            // 
            this.interstellarPictureBox.Image = global::MusicShopUI.Properties.Resources.interstellar;
            this.interstellarPictureBox.Location = new System.Drawing.Point(480, 371);
            this.interstellarPictureBox.Name = "interstellarPictureBox";
            this.interstellarPictureBox.Size = new System.Drawing.Size(412, 327);
            this.interstellarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.interstellarPictureBox.TabIndex = 34;
            this.interstellarPictureBox.TabStop = false;
            this.interstellarPictureBox.Visible = false;
            // 
            // plasticBeachPictureBox
            // 
            this.plasticBeachPictureBox.Image = global::MusicShopUI.Properties.Resources.plastic_beach;
            this.plasticBeachPictureBox.Location = new System.Drawing.Point(480, 371);
            this.plasticBeachPictureBox.Name = "plasticBeachPictureBox";
            this.plasticBeachPictureBox.Size = new System.Drawing.Size(412, 327);
            this.plasticBeachPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plasticBeachPictureBox.TabIndex = 33;
            this.plasticBeachPictureBox.TabStop = false;
            this.plasticBeachPictureBox.Visible = false;
            // 
            // zletowarzystwoPictureBox
            // 
            this.zletowarzystwoPictureBox.Image = global::MusicShopUI.Properties.Resources.zle_towarzystwo;
            this.zletowarzystwoPictureBox.Location = new System.Drawing.Point(480, 371);
            this.zletowarzystwoPictureBox.Name = "zletowarzystwoPictureBox";
            this.zletowarzystwoPictureBox.Size = new System.Drawing.Size(412, 327);
            this.zletowarzystwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zletowarzystwoPictureBox.TabIndex = 25;
            this.zletowarzystwoPictureBox.TabStop = false;
            this.zletowarzystwoPictureBox.Visible = false;
            // 
            // monochromyPictureBox
            // 
            this.monochromyPictureBox.Image = global::MusicShopUI.Properties.Resources.monochromy;
            this.monochromyPictureBox.Location = new System.Drawing.Point(480, 371);
            this.monochromyPictureBox.Name = "monochromyPictureBox";
            this.monochromyPictureBox.Size = new System.Drawing.Size(412, 327);
            this.monochromyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monochromyPictureBox.TabIndex = 24;
            this.monochromyPictureBox.TabStop = false;
            this.monochromyPictureBox.Visible = false;
            // 
            // younghemsPictureBox
            // 
            this.younghemsPictureBox.Image = global::MusicShopUI.Properties.Resources.young_hems;
            this.younghemsPictureBox.Location = new System.Drawing.Point(480, 371);
            this.younghemsPictureBox.Name = "younghemsPictureBox";
            this.younghemsPictureBox.Size = new System.Drawing.Size(412, 326);
            this.younghemsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.younghemsPictureBox.TabIndex = 23;
            this.younghemsPictureBox.TabStop = false;
            this.younghemsPictureBox.Visible = false;
            // 
            // trojkatwarszawskiPictureBox
            // 
            this.trojkatwarszawskiPictureBox.Image = global::MusicShopUI.Properties.Resources.trojkat_warszawski;
            this.trojkatwarszawskiPictureBox.Location = new System.Drawing.Point(480, 370);
            this.trojkatwarszawskiPictureBox.Name = "trojkatwarszawskiPictureBox";
            this.trojkatwarszawskiPictureBox.Size = new System.Drawing.Size(412, 326);
            this.trojkatwarszawskiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trojkatwarszawskiPictureBox.TabIndex = 22;
            this.trojkatwarszawskiPictureBox.TabStop = false;
            this.trojkatwarszawskiPictureBox.Visible = false;
            // 
            // stop
            // 
            this.stop.BackgroundImage = global::MusicShopUI.Properties.Resources.mediaStop1;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop.Location = new System.Drawing.Point(1202, 644);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(140, 107);
            this.stop.TabIndex = 21;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // play
            // 
            this.play.BackgroundImage = global::MusicShopUI.Properties.Resources.mediaPlay1;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Cursor = System.Windows.Forms.Cursors.Default;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.Location = new System.Drawing.Point(940, 644);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(137, 107);
            this.play.TabIndex = 20;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // MusicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 763);
            this.Controls.Add(this.interstellarPictureBox);
            this.Controls.Add(this.plasticBeachPictureBox);
            this.Controls.Add(this.buttonCreatePDF);
            this.Controls.Add(this.zletowarzystwoPictureBox);
            this.Controls.Add(this.monochromyPictureBox);
            this.Controls.Add(this.younghemsPictureBox);
            this.Controls.Add(this.trojkatwarszawskiPictureBox);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.playlistListBoxLabel);
            this.Controls.Add(this.playlistListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.purchasedAlbumsListboxLabel);
            this.Controls.Add(this.purchasedAlbumsListbox);
            this.Controls.Add(this.backToStore);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.artistListboxLabel);
            this.Controls.Add(this.artistsListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.albumsListboxLabel);
            this.Controls.Add(this.albumsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MusicShop";
            this.Text = "Music Shop";
            this.Load += new System.EventHandler(this.MusicShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interstellarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticBeachPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zletowarzystwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monochromyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.younghemsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trojkatwarszawskiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox albumsListbox;
        private System.Windows.Forms.Label albumsListboxLabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label artistListboxLabel;
        private System.Windows.Forms.ListBox artistsListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Button backToStore;
        private System.Windows.Forms.Label purchasedAlbumsListboxLabel;
        public System.Windows.Forms.ListBox purchasedAlbumsListbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label playlistListBoxLabel;
        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox trojkatwarszawskiPictureBox;
        private System.Windows.Forms.PictureBox younghemsPictureBox;
        private System.Windows.Forms.PictureBox monochromyPictureBox;
        private System.Windows.Forms.PictureBox zletowarzystwoPictureBox;
        private System.Windows.Forms.Button buttonCreatePDF;
        private System.Windows.Forms.PictureBox plasticBeachPictureBox;
        private System.Windows.Forms.PictureBox interstellarPictureBox;
    }
}