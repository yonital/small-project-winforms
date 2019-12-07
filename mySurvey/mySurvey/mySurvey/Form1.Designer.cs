namespace mySurvey
{
    partial class Form1
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
            this.headline = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.kindCheck = new System.Windows.Forms.CheckBox();
            this.likes = new System.Windows.Forms.Label();
            this.dislikes = new System.Windows.Forms.Label();
            this.carryCheck = new System.Windows.Forms.CheckBox();
            this.motivatedCheck = new System.Windows.Forms.CheckBox();
            this.funnyCheck = new System.Windows.Forms.CheckBox();
            this.jelousCheck = new System.Windows.Forms.CheckBox();
            this.annoyingCheck = new System.Windows.Forms.CheckBox();
            this.lazyCheck = new System.Windows.Forms.CheckBox();
            this.crazyCheck = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.ListDateLocation = new System.Windows.Forms.ListBox();
            this.favDateLocation = new System.Windows.Forms.Label();
            this.ComboFood = new System.Windows.Forms.ComboBox();
            this.favouriteFood = new System.Windows.Forms.Label();
            this.dateDay = new System.Windows.Forms.Label();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clockBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.foodPicBox = new System.Windows.Forms.PictureBox();
            this.adminButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.SystemColors.ControlDark;
            this.headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headline.Location = new System.Drawing.Point(169, 19);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(539, 37);
            this.headline.TabIndex = 0;
            this.headline.Text = "Life Mate Survey - totally anonymous";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(29, 86);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(86, 20);
            this.fName.TabIndex = 1;
            this.fName.Text = "First Name";
            // 
            // fNameBox
            // 
            this.fNameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.Location = new System.Drawing.Point(131, 83);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(100, 26);
            this.fNameBox.TabIndex = 2;
            // 
            // lNameBox
            // 
            this.lNameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.Location = new System.Drawing.Point(131, 119);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(100, 26);
            this.lNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(131, 155);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 26);
            this.emailBox.TabIndex = 6;
            this.emailBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailBox_Validating);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(29, 158);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // mobileBox
            // 
            this.mobileBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mobileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileBox.Location = new System.Drawing.Point(131, 192);
            this.mobileBox.MaxLength = 10;
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(100, 26);
            this.mobileBox.TabIndex = 8;
            this.mobileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileBox_KeyPress);
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(29, 195);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(55, 20);
            this.Mobile.TabIndex = 7;
            this.Mobile.Text = "Mobile";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(29, 239);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(67, 20);
            this.gender.TabIndex = 9;
            this.gender.Text = "Gender:";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.Location = new System.Drawing.Point(127, 241);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(53, 19);
            this.maleButton.TabIndex = 10;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(186, 241);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(67, 19);
            this.femaleButton.TabIndex = 11;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // kindCheck
            // 
            this.kindCheck.AutoSize = true;
            this.kindCheck.Location = new System.Drawing.Point(127, 283);
            this.kindCheck.Name = "kindCheck";
            this.kindCheck.Size = new System.Drawing.Size(46, 17);
            this.kindCheck.TabIndex = 12;
            this.kindCheck.Text = "kind";
            this.kindCheck.UseVisualStyleBackColor = true;
            // 
            // likes
            // 
            this.likes.AutoSize = true;
            this.likes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likes.Location = new System.Drawing.Point(29, 279);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(50, 20);
            this.likes.TabIndex = 13;
            this.likes.Text = "Likes:";
            // 
            // dislikes
            // 
            this.dislikes.AutoSize = true;
            this.dislikes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislikes.Location = new System.Drawing.Point(29, 347);
            this.dislikes.Name = "dislikes";
            this.dislikes.Size = new System.Drawing.Size(67, 20);
            this.dislikes.TabIndex = 14;
            this.dislikes.Text = "Dislikes:";
            // 
            // carryCheck
            // 
            this.carryCheck.AutoSize = true;
            this.carryCheck.Location = new System.Drawing.Point(186, 283);
            this.carryCheck.Name = "carryCheck";
            this.carryCheck.Size = new System.Drawing.Size(63, 17);
            this.carryCheck.TabIndex = 15;
            this.carryCheck.Text = "carrying";
            this.carryCheck.UseVisualStyleBackColor = true;
            // 
            // motivatedCheck
            // 
            this.motivatedCheck.AutoSize = true;
            this.motivatedCheck.Location = new System.Drawing.Point(127, 306);
            this.motivatedCheck.Name = "motivatedCheck";
            this.motivatedCheck.Size = new System.Drawing.Size(72, 17);
            this.motivatedCheck.TabIndex = 16;
            this.motivatedCheck.Text = "motivated";
            this.motivatedCheck.UseVisualStyleBackColor = true;
            // 
            // funnyCheck
            // 
            this.funnyCheck.AutoSize = true;
            this.funnyCheck.Location = new System.Drawing.Point(205, 306);
            this.funnyCheck.Name = "funnyCheck";
            this.funnyCheck.Size = new System.Drawing.Size(52, 17);
            this.funnyCheck.TabIndex = 17;
            this.funnyCheck.Text = "funny";
            this.funnyCheck.UseVisualStyleBackColor = true;
            // 
            // jelousCheck
            // 
            this.jelousCheck.AutoSize = true;
            this.jelousCheck.Location = new System.Drawing.Point(127, 347);
            this.jelousCheck.Name = "jelousCheck";
            this.jelousCheck.Size = new System.Drawing.Size(53, 17);
            this.jelousCheck.TabIndex = 18;
            this.jelousCheck.Text = "jelous";
            this.jelousCheck.UseVisualStyleBackColor = true;
            // 
            // annoyingCheck
            // 
            this.annoyingCheck.AutoSize = true;
            this.annoyingCheck.Location = new System.Drawing.Point(186, 347);
            this.annoyingCheck.Name = "annoyingCheck";
            this.annoyingCheck.Size = new System.Drawing.Size(69, 17);
            this.annoyingCheck.TabIndex = 19;
            this.annoyingCheck.Text = "annoying";
            this.annoyingCheck.UseVisualStyleBackColor = true;
            // 
            // lazyCheck
            // 
            this.lazyCheck.AutoSize = true;
            this.lazyCheck.Location = new System.Drawing.Point(127, 370);
            this.lazyCheck.Name = "lazyCheck";
            this.lazyCheck.Size = new System.Drawing.Size(44, 17);
            this.lazyCheck.TabIndex = 20;
            this.lazyCheck.Text = "lazy";
            this.lazyCheck.UseVisualStyleBackColor = true;
            // 
            // crazyCheck
            // 
            this.crazyCheck.AutoSize = true;
            this.crazyCheck.Location = new System.Drawing.Point(176, 370);
            this.crazyCheck.Name = "crazyCheck";
            this.crazyCheck.Size = new System.Drawing.Size(51, 17);
            this.crazyCheck.TabIndex = 21;
            this.crazyCheck.Text = "crazy";
            this.crazyCheck.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(530, 370);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.Red;
            this.clearAllButton.ForeColor = System.Drawing.Color.White;
            this.clearAllButton.Location = new System.Drawing.Point(611, 370);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 23;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // ListDateLocation
            // 
            this.ListDateLocation.FormattingEnabled = true;
            this.ListDateLocation.Items.AddRange(new object[] {
            "Restaurant",
            "Pub",
            "Sea",
            "Garden",
            "His/Her`s Home",
            "Your Home",
            "Coffee Shop",
            "Other"});
            this.ListDateLocation.Location = new System.Drawing.Point(429, 82);
            this.ListDateLocation.Name = "ListDateLocation";
            this.ListDateLocation.Size = new System.Drawing.Size(120, 95);
            this.ListDateLocation.TabIndex = 24;
            // 
            // favDateLocation
            // 
            this.favDateLocation.AutoSize = true;
            this.favDateLocation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.favDateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favDateLocation.Location = new System.Drawing.Point(297, 82);
            this.favDateLocation.Name = "favDateLocation";
            this.favDateLocation.Size = new System.Drawing.Size(113, 20);
            this.favDateLocation.TabIndex = 25;
            this.favDateLocation.Text = "Date Location:";
            // 
            // ComboFood
            // 
            this.ComboFood.FormattingEnabled = true;
            this.ComboFood.Items.AddRange(new object[] {
            "Chips",
            "Pizza",
            "Hamburger",
            "KFC",
            "BBB",
            "Sushi"});
            this.ComboFood.Location = new System.Drawing.Point(429, 207);
            this.ComboFood.Name = "ComboFood";
            this.ComboFood.Size = new System.Drawing.Size(121, 21);
            this.ComboFood.TabIndex = 26;
            this.ComboFood.SelectedIndexChanged += new System.EventHandler(this.ComboFood_SelectedIndexChanged);
            // 
            // favouriteFood
            // 
            this.favouriteFood.AutoSize = true;
            this.favouriteFood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.favouriteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteFood.Location = new System.Drawing.Point(290, 207);
            this.favouriteFood.Name = "favouriteFood";
            this.favouriteFood.Size = new System.Drawing.Size(120, 20);
            this.favouriteFood.TabIndex = 27;
            this.favouriteFood.Text = "Favourite Food:";
            // 
            // dateDay
            // 
            this.dateDay.AutoSize = true;
            this.dateDay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDay.Location = new System.Drawing.Point(330, 240);
            this.dateDay.Name = "dateDay";
            this.dateDay.Size = new System.Drawing.Size(80, 20);
            this.dateDay.TabIndex = 29;
            this.dateDay.Text = "Date Day:";
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboDay.Location = new System.Drawing.Point(429, 239);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(121, 21);
            this.comboDay.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clockBox
            // 
            this.clockBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clockBox.Location = new System.Drawing.Point(732, 35);
            this.clockBox.Name = "clockBox";
            this.clockBox.Size = new System.Drawing.Size(49, 20);
            this.clockBox.TabIndex = 30;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // foodPicBox
            // 
            this.foodPicBox.Location = new System.Drawing.Point(559, 97);
            this.foodPicBox.Name = "foodPicBox";
            this.foodPicBox.Size = new System.Drawing.Size(127, 130);
            this.foodPicBox.TabIndex = 31;
            this.foodPicBox.TabStop = false;
            this.foodPicBox.Visible = false;
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(13, 19);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 32;
            this.adminButton.Text = "admin auth";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mySurvey.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 439);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.foodPicBox);
            this.Controls.Add(this.clockBox);
            this.Controls.Add(this.dateDay);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.favouriteFood);
            this.Controls.Add(this.ComboFood);
            this.Controls.Add(this.favDateLocation);
            this.Controls.Add(this.ListDateLocation);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.crazyCheck);
            this.Controls.Add(this.lazyCheck);
            this.Controls.Add(this.annoyingCheck);
            this.Controls.Add(this.jelousCheck);
            this.Controls.Add(this.funnyCheck);
            this.Controls.Add(this.motivatedCheck);
            this.Controls.Add(this.carryCheck);
            this.Controls.Add(this.dislikes);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.kindCheck);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.headline);
            this.Name = "Form1";
            this.Text = "Life Mate Survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.CheckBox kindCheck;
        private System.Windows.Forms.Label likes;
        private System.Windows.Forms.Label dislikes;
        private System.Windows.Forms.CheckBox carryCheck;
        private System.Windows.Forms.CheckBox motivatedCheck;
        private System.Windows.Forms.CheckBox funnyCheck;
        private System.Windows.Forms.CheckBox jelousCheck;
        private System.Windows.Forms.CheckBox annoyingCheck;
        private System.Windows.Forms.CheckBox lazyCheck;
        private System.Windows.Forms.CheckBox crazyCheck;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.ListBox ListDateLocation;
        private System.Windows.Forms.Label favDateLocation;
        private System.Windows.Forms.ComboBox ComboFood;
        private System.Windows.Forms.Label favouriteFood;
        private System.Windows.Forms.Label dateDay;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox clockBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox foodPicBox;
        private System.Windows.Forms.Button adminButton;
    }
}

