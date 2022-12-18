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
            this.AddToCart = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.artistsListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.backToStore = new System.Windows.Forms.Button();
            this.purchasedAlbumsListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.buttonCreatePDF = new System.Windows.Forms.Button();
            this.nextWindowFormBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.interstellarPictureBox = new System.Windows.Forms.PictureBox();
            this.plasticBeachPictureBox = new System.Windows.Forms.PictureBox();
            this.zletowarzystwoPictureBox = new System.Windows.Forms.PictureBox();
            this.monochromyPictureBox = new System.Windows.Forms.PictureBox();
            this.younghemsPictureBox = new System.Windows.Forms.PictureBox();
            this.trojkatwarszawskiPictureBox = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.buttonCreateXLS = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.createDatabase = new System.Windows.Forms.Button();
            this.createTables = new System.Windows.Forms.Button();
            this.addNewAlbumDB = new System.Windows.Forms.Button();
            this.deleteAlbumDB = new System.Windows.Forms.Button();
            this.deleteDatabase = new System.Windows.Forms.Button();
            this.updateRecordAlbum = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
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
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddToCart.Location = new System.Drawing.Point(384, 108);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(138, 50);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add ->";
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
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
            this.makePurchase.Location = new System.Drawing.Point(559, 309);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(138, 50);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Buy Now";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
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
            this.storeProfitLabel.Location = new System.Drawing.Point(1111, 313);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(111, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit: ";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeProfitValue.Location = new System.Drawing.Point(1217, 313);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(82, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "0,00 PLN";
            // 
            // backToStore
            // 
            this.backToStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backToStore.Location = new System.Drawing.Point(384, 164);
            this.backToStore.Name = "backToStore";
            this.backToStore.Size = new System.Drawing.Size(138, 50);
            this.backToStore.TabIndex = 11;
            this.backToStore.Text = "<- Back";
            this.backToStore.UseVisualStyleBackColor = false;
            this.backToStore.Click += new System.EventHandler(this.BackToStore_Click);
            // 
            // purchasedAlbumsListbox
            // 
            this.purchasedAlbumsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchasedAlbumsListbox.FormattingEnabled = true;
            this.purchasedAlbumsListbox.ItemHeight = 20;
            this.purchasedAlbumsListbox.Location = new System.Drawing.Point(5, 38);
            this.purchasedAlbumsListbox.Margin = new System.Windows.Forms.Padding(2);
            this.purchasedAlbumsListbox.Name = "purchasedAlbumsListbox";
            this.purchasedAlbumsListbox.Size = new System.Drawing.Size(333, 264);
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
            this.buttonCreatePDF.BackColor = System.Drawing.Color.White;
            this.buttonCreatePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreatePDF.BackgroundImage")));
            this.buttonCreatePDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreatePDF.Location = new System.Drawing.Point(17, 644);
            this.buttonCreatePDF.Name = "buttonCreatePDF";
            this.buttonCreatePDF.Size = new System.Drawing.Size(110, 113);
            this.buttonCreatePDF.TabIndex = 26;
            this.buttonCreatePDF.UseVisualStyleBackColor = false;
            this.buttonCreatePDF.Click += new System.EventHandler(this.buttonCreatePDF_Click);
            // 
            // nextWindowFormBtn
            // 
            this.nextWindowFormBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextWindowFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextWindowFormBtn.Location = new System.Drawing.Point(754, 309);
            this.nextWindowFormBtn.Name = "nextWindowFormBtn";
            this.nextWindowFormBtn.Size = new System.Drawing.Size(138, 50);
            this.nextWindowFormBtn.TabIndex = 35;
            this.nextWindowFormBtn.Text = "Next ->";
            this.nextWindowFormBtn.UseVisualStyleBackColor = false;
            this.nextWindowFormBtn.Click += new System.EventHandler(this.nextWindowFormBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 250);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Albums";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.purchasedAlbumsListbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 306);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Albums";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(550, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 250);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(931, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 250);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Artists";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(931, 336);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(419, 302);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Your Playlist";
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
            this.stop.BackgroundImage = global::MusicShopUI.Properties.Resources.stopBtn;
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
            this.play.BackgroundImage = global::MusicShopUI.Properties.Resources.playBtn;
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
            // buttonCreateXLS
            // 
            this.buttonCreateXLS.BackColor = System.Drawing.Color.White;
            this.buttonCreateXLS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateXLS.BackgroundImage")));
            this.buttonCreateXLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateXLS.Location = new System.Drawing.Point(240, 644);
            this.buttonCreateXLS.Name = "buttonCreateXLS";
            this.buttonCreateXLS.Size = new System.Drawing.Size(110, 113);
            this.buttonCreateXLS.TabIndex = 41;
            this.buttonCreateXLS.UseVisualStyleBackColor = false;
            this.buttonCreateXLS.Click += new System.EventHandler(this.buttonCreateXLS_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(384, 262);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(147, 31);
            this.txtTitle.TabIndex = 42;
            // 
            // createDatabase
            // 
            this.createDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createDatabase.Location = new System.Drawing.Point(394, 339);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(138, 50);
            this.createDatabase.TabIndex = 44;
            this.createDatabase.Text = "Create Database";
            this.createDatabase.UseVisualStyleBackColor = false;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // createTables
            // 
            this.createTables.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTables.Location = new System.Drawing.Point(393, 395);
            this.createTables.Name = "createTables";
            this.createTables.Size = new System.Drawing.Size(138, 50);
            this.createTables.TabIndex = 45;
            this.createTables.Text = "Create Tables";
            this.createTables.UseVisualStyleBackColor = false;
            this.createTables.Click += new System.EventHandler(this.createTables_Click);
            // 
            // addNewAlbumDB
            // 
            this.addNewAlbumDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewAlbumDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewAlbumDB.Location = new System.Drawing.Point(394, 451);
            this.addNewAlbumDB.Name = "addNewAlbumDB";
            this.addNewAlbumDB.Size = new System.Drawing.Size(138, 50);
            this.addNewAlbumDB.TabIndex = 46;
            this.addNewAlbumDB.Text = "Add New Album";
            this.addNewAlbumDB.UseVisualStyleBackColor = false;
            this.addNewAlbumDB.Click += new System.EventHandler(this.addNewAlbumDB_Click);
            // 
            // deleteAlbumDB
            // 
            this.deleteAlbumDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteAlbumDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteAlbumDB.Location = new System.Drawing.Point(394, 563);
            this.deleteAlbumDB.Name = "deleteAlbumDB";
            this.deleteAlbumDB.Size = new System.Drawing.Size(138, 50);
            this.deleteAlbumDB.TabIndex = 47;
            this.deleteAlbumDB.Text = "Delete Album";
            this.deleteAlbumDB.UseVisualStyleBackColor = false;
            this.deleteAlbumDB.Click += new System.EventHandler(this.deleteAlbumDB_Click);
            // 
            // deleteDatabase
            // 
            this.deleteDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteDatabase.Location = new System.Drawing.Point(393, 619);
            this.deleteDatabase.Name = "deleteDatabase";
            this.deleteDatabase.Size = new System.Drawing.Size(138, 50);
            this.deleteDatabase.TabIndex = 48;
            this.deleteDatabase.Text = "Delete Database";
            this.deleteDatabase.UseVisualStyleBackColor = false;
            this.deleteDatabase.Click += new System.EventHandler(this.deleteDatabase_Click);
            // 
            // updateRecordAlbum
            // 
            this.updateRecordAlbum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateRecordAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateRecordAlbum.Location = new System.Drawing.Point(394, 507);
            this.updateRecordAlbum.Name = "updateRecordAlbum";
            this.updateRecordAlbum.Size = new System.Drawing.Size(138, 50);
            this.updateRecordAlbum.TabIndex = 49;
            this.updateRecordAlbum.Text = "Update Album";
            this.updateRecordAlbum.UseVisualStyleBackColor = false;
            this.updateRecordAlbum.Click += new System.EventHandler(this.updateRecordAlbum_Click);
            // 
            // MusicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 763);
            this.Controls.Add(this.updateRecordAlbum);
            this.Controls.Add(this.deleteDatabase);
            this.Controls.Add(this.deleteAlbumDB);
            this.Controls.Add(this.addNewAlbumDB);
            this.Controls.Add(this.createTables);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.buttonCreateXLS);
            this.Controls.Add(this.nextWindowFormBtn);
            this.Controls.Add(this.interstellarPictureBox);
            this.Controls.Add(this.plasticBeachPictureBox);
            this.Controls.Add(this.buttonCreatePDF);
            this.Controls.Add(this.zletowarzystwoPictureBox);
            this.Controls.Add(this.monochromyPictureBox);
            this.Controls.Add(this.younghemsPictureBox);
            this.Controls.Add(this.trojkatwarszawskiPictureBox);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.playlistListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backToStore);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.artistsListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.albumsListbox);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MusicShop";
            this.Text = "Music Shop";
            this.Load += new System.EventHandler(this.MusicShop_Load);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox artistsListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Button backToStore;
        public System.Windows.Forms.ListBox purchasedAlbumsListbox;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button nextWindowFormBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCreateXLS;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button createDatabase;
        private System.Windows.Forms.Button createTables;
        private System.Windows.Forms.Button addNewAlbumDB;
        private System.Windows.Forms.Button deleteAlbumDB;
        private System.Windows.Forms.Button deleteDatabase;
        private System.Windows.Forms.Button updateRecordAlbum;
    }
}