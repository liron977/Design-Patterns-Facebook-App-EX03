
namespace BasicFacebookFeatures
{
    partial class UserProfileForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label nameLabel;
            this.posts = new System.Windows.Forms.ListBox();
            this.PostStatusbutton = new System.Windows.Forms.Button();
            this.PostStatusTextBox = new System.Windows.Forms.TextBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.FriendsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.UpcomingBirthdaysLabel = new System.Windows.Forms.Label();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton3DaysFilter = new System.Windows.Forms.RadioButton();
            this.radioButton7DaysFilter = new System.Windows.Forms.RadioButton();
            this.radioButtonIn30days = new System.Windows.Forms.RadioButton();
            imageAlbumLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Location = new System.Drawing.Point(8, 57);
            imageAlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(71, 13);
            imageAlbumLabel.TabIndex = 0;
            imageAlbumLabel.Text = "Image Album:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 162);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // posts
            // 
            this.posts.FormattingEnabled = true;
            this.posts.Location = new System.Drawing.Point(202, 157);
            this.posts.Margin = new System.Windows.Forms.Padding(2);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(187, 173);
            this.posts.TabIndex = 1;
            // 
            // PostStatusbutton
            // 
            this.PostStatusbutton.Location = new System.Drawing.Point(338, 116);
            this.PostStatusbutton.Margin = new System.Windows.Forms.Padding(2);
            this.PostStatusbutton.Name = "PostStatusbutton";
            this.PostStatusbutton.Size = new System.Drawing.Size(50, 21);
            this.PostStatusbutton.TabIndex = 2;
            this.PostStatusbutton.Text = "Post!";
            this.PostStatusbutton.UseVisualStyleBackColor = true;
            this.PostStatusbutton.Click += new System.EventHandler(this.postStatusButton_Click_1);
            // 
            // PostStatusTextBox
            // 
            this.PostStatusTextBox.Location = new System.Drawing.Point(202, 121);
            this.PostStatusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostStatusTextBox.Name = "PostStatusTextBox";
            this.PostStatusTextBox.Size = new System.Drawing.Size(110, 20);
            this.PostStatusTextBox.TabIndex = 3;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(250, 5);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(82, 66);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(29, 99);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(117, 134);
            this.friendsListBox.TabIndex = 4;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // FriendsLabel
            // 
            this.FriendsLabel.AutoSize = true;
            this.FriendsLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FriendsLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FriendsLabel.Location = new System.Drawing.Point(57, 72);
            this.FriendsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendsLabel.Name = "FriendsLabel";
            this.FriendsLabel.Size = new System.Drawing.Size(74, 19);
            this.FriendsLabel.TabIndex = 5;
            this.FriendsLabel.Text = "Friends";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(199, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Whats in your mind?";
            // 
            // upcomingBirthdaysListBox
            // 
            this.upcomingBirthdaysListBox.FormattingEnabled = true;
            this.upcomingBirthdaysListBox.Location = new System.Drawing.Point(11, 329);
            this.upcomingBirthdaysListBox.Margin = new System.Windows.Forms.Padding(2);
            this.upcomingBirthdaysListBox.Name = "upcomingBirthdaysListBox";
            this.upcomingBirthdaysListBox.Size = new System.Drawing.Size(163, 56);
            this.upcomingBirthdaysListBox.TabIndex = 8;
            // 
            // UpcomingBirthdaysLabel
            // 
            this.UpcomingBirthdaysLabel.AutoSize = true;
            this.UpcomingBirthdaysLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpcomingBirthdaysLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpcomingBirthdaysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UpcomingBirthdaysLabel.Location = new System.Drawing.Point(6, 249);
            this.UpcomingBirthdaysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpcomingBirthdaysLabel.Name = "UpcomingBirthdaysLabel";
            this.UpcomingBirthdaysLabel.Size = new System.Drawing.Size(192, 19);
            this.UpcomingBirthdaysLabel.TabIndex = 9;
            this.UpcomingBirthdaysLabel.Text = "Upcoming Birthdays";
            // 
            // albumListBox
            // 
            this.albumListBox.DataSource = this.albumBindingSource;
            this.albumListBox.DisplayMember = "Name";
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.Location = new System.Drawing.Point(432, 72);
            this.albumListBox.Margin = new System.Windows.Forms.Padding(2);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(185, 82);
            this.albumListBox.TabIndex = 10;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.AlbumsLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AlbumsLabel.Location = new System.Drawing.Point(436, 30);
            this.AlbumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(76, 19);
            this.AlbumsLabel.TabIndex = 11;
            this.AlbumsLabel.Text = "Albums";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(imageAlbumLabel);
            this.panel1.Controls.Add(this.imageAlbumPictureBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(432, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 193);
            this.panel1.TabIndex = 16;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(93, 15);
            this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(132, 113);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 1;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 158);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.albumBindingSource;
            // 
            // radioButton3DaysFilter
            // 
            this.radioButton3DaysFilter.AutoSize = true;
            this.radioButton3DaysFilter.Location = new System.Drawing.Point(1, 284);
            this.radioButton3DaysFilter.Name = "radioButton3DaysFilter";
            this.radioButton3DaysFilter.Size = new System.Drawing.Size(68, 17);
            this.radioButton3DaysFilter.TabIndex = 17;
            this.radioButton3DaysFilter.TabStop = true;
            this.radioButton3DaysFilter.Text = "In 3 days";
            this.radioButton3DaysFilter.UseVisualStyleBackColor = true;
           // this.radioButton3DaysFilter.CheckedChanged += new System.EventHandler(this.radioButton3DaysFilter_CheckedChanged);
            this.radioButton3DaysFilter.Click += new System.EventHandler(this.radioButton3DaysFilter_Click);
            // 
            // radioButton7DaysFilter
            // 
            this.radioButton7DaysFilter.AutoSize = true;
            this.radioButton7DaysFilter.Location = new System.Drawing.Point(92, 284);
            this.radioButton7DaysFilter.Name = "radioButton7DaysFilter";
            this.radioButton7DaysFilter.Size = new System.Drawing.Size(68, 17);
            this.radioButton7DaysFilter.TabIndex = 18;
            this.radioButton7DaysFilter.TabStop = true;
            this.radioButton7DaysFilter.Text = "In 7 days";
            this.radioButton7DaysFilter.UseVisualStyleBackColor = true;
            this.radioButton7DaysFilter.Click += new System.EventHandler(this.radioButton7DaysFilter_Click);
            // 
            // radioButtonIn30days
            // 
            this.radioButtonIn30days.AutoSize = true;
            this.radioButtonIn30days.Location = new System.Drawing.Point(46, 303);
            this.radioButtonIn30days.Name = "radioButtonIn30days";
            this.radioButtonIn30days.Size = new System.Drawing.Size(74, 17);
            this.radioButtonIn30days.TabIndex = 19;
            this.radioButtonIn30days.TabStop = true;
            this.radioButtonIn30days.Text = "In 30 days";
            this.radioButtonIn30days.UseVisualStyleBackColor = true;
            this.radioButtonIn30days.Click += new System.EventHandler(this.radioButtonIn30days_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(766, 402);
            this.Controls.Add(this.radioButtonIn30days);
            this.Controls.Add(this.radioButton7DaysFilter);
            this.Controls.Add(this.radioButton3DaysFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.albumListBox);
            this.Controls.Add(this.UpcomingBirthdaysLabel);
            this.Controls.Add(this.upcomingBirthdaysListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FriendsLabel);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.PostStatusTextBox);
            this.Controls.Add(this.PostStatusbutton);
            this.Controls.Add(this.posts);
            this.Controls.Add(this.ProfilePicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.ListBox posts;
        private System.Windows.Forms.Button PostStatusbutton;
        private System.Windows.Forms.TextBox PostStatusTextBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label FriendsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox upcomingBirthdaysListBox;
        private System.Windows.Forms.Label UpcomingBirthdaysLabel;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.RadioButton radioButton3DaysFilter;
        private System.Windows.Forms.RadioButton radioButton7DaysFilter;
        private System.Windows.Forms.RadioButton radioButtonIn30days;
    }
}