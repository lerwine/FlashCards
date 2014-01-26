namespace Erwine.Leonard.Thomas.Flash_Cards
{
    partial class SetupForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sampleDeckTextCard = new Erwine.Leonard.Thomas.WindowsFormsControls.TextCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.foregroundPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundImagePictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPatternComboBox = new System.Windows.Forms.ComboBox();
            this.alternateBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.fillTypeComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundColorPictureBox = new System.Windows.Forms.PictureBox();
            this.borderColorPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundImageButton = new System.Windows.Forms.Button();
            this.backgroundPatternLabel = new System.Windows.Forms.Label();
            this.fillTypeLabel = new System.Windows.Forms.Label();
            this.imageWrapLabel = new System.Windows.Forms.Label();
            this.imageWrapComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.deck1 = new Erwine.Leonard.Thomas.Flash_Cards.Data.Deck(this.components);
            this.foreColorComboBox = new System.Windows.Forms.ComboBox();
            this.borderColorComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundColor1ComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundColor2ComboBox = new System.Windows.Forms.ComboBox();
            this.foreColorLabel = new System.Windows.Forms.Label();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.backgroundColor1label = new System.Windows.Forms.Label();
            this.backgroundColor2Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternateBackgroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorPictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.sampleDeckTextCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sampleDeckTextCard
            // 
            this.sampleDeckTextCard.BackColor = System.Drawing.Color.Transparent;
            this.sampleDeckTextCard.BackColor1 = System.Drawing.Color.Gold;
            this.sampleDeckTextCard.BackColor2 = System.Drawing.Color.IndianRed;
            this.sampleDeckTextCard.CardBorderColor = System.Drawing.Color.DarkRed;
            this.sampleDeckTextCard.CardBorderWidth = 4;
            this.sampleDeckTextCard.CardsShownBehind = 4;
            this.sampleDeckTextCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleDeckTextCard.FillType = Erwine.Leonard.Thomas.WindowsFormsControls.TextCard.FillTypeEnum.HatchFill;
            this.sampleDeckTextCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleDeckTextCard.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.sampleDeckTextCard.Location = new System.Drawing.Point(0, 0);
            this.sampleDeckTextCard.Margin = new System.Windows.Forms.Padding(0);
            this.sampleDeckTextCard.Name = "sampleDeckTextCard";
            this.sampleDeckTextCard.Size = new System.Drawing.Size(219, 382);
            this.sampleDeckTextCard.TabIndex = 0;
            this.sampleDeckTextCard.Texture = null;
            this.sampleDeckTextCard.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.foregroundPictureBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.backgroundImagePictureBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.backgroundPatternComboBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.alternateBackgroundPictureBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.fillTypeComboBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColorPictureBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.borderColorPictureBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.backgroundImageButton, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.backgroundPatternLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.fillTypeLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.imageWrapLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.imageWrapComboBox, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.foreColorComboBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.borderColorComboBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColor1ComboBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColor2ComboBox, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.foreColorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.borderColorLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColor1label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColor2Label, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(222, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 376);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // foregroundPictureBox
            // 
            this.foregroundPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foregroundPictureBox.BackColor = System.Drawing.Color.Black;
            this.foregroundPictureBox.Location = new System.Drawing.Point(133, 29);
            this.foregroundPictureBox.Name = "foregroundPictureBox";
            this.foregroundPictureBox.Size = new System.Drawing.Size(23, 23);
            this.foregroundPictureBox.TabIndex = 1;
            this.foregroundPictureBox.TabStop = false;
            // 
            // backgroundImagePictureBox
            // 
            this.backgroundImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.backgroundImagePictureBox, 2);
            this.backgroundImagePictureBox.Location = new System.Drawing.Point(133, 199);
            this.backgroundImagePictureBox.Name = "backgroundImagePictureBox";
            this.backgroundImagePictureBox.Size = new System.Drawing.Size(181, 118);
            this.backgroundImagePictureBox.TabIndex = 10;
            this.backgroundImagePictureBox.TabStop = false;
            // 
            // backgroundPatternComboBox
            // 
            this.backgroundPatternComboBox.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel2.SetColumnSpan(this.backgroundPatternComboBox, 2);
            this.backgroundPatternComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundPatternComboBox.ForeColor = System.Drawing.Color.Black;
            this.backgroundPatternComboBox.FormattingEnabled = true;
            this.backgroundPatternComboBox.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Forward Diagonal",
            "Backward Diagonal",
            "Max",
            "Cross",
            "Large Grid",
            "Diagonal Cross",
            "5 %",
            "10 %",
            "20 %",
            "25 %",
            "30 %",
            "40 %",
            "50 %",
            "60 %",
            "70 %",
            "75 %",
            "80 %",
            "90 %",
            "Light Downward Diagonal",
            "Light Upward Diagonal",
            "Dark Downward Diagonal",
            "Dark Upward Diagonal",
            "Wide Downward Diagonal",
            "Wide Upward Diagonal",
            "Light Vertical",
            "Light Horizontal",
            "Narrow Vertical",
            "Narrow Horizontal",
            "Dark Vertical",
            "Dark Horizontal",
            "Dashed Downward Diagonal",
            "Dashed Upward Diagonal",
            "Dashed Horizontal",
            "Dashed Vertical",
            "Small Confetti",
            "Large Confetti",
            "Zig Zag",
            "Wave",
            "Diagonal Brick",
            "Horizontal Brick",
            "Weave",
            "Plaid",
            "Divot",
            "Dotted Grid",
            "Dotted Diamond",
            "Shingle",
            "Trellis",
            "Sphere",
            "Small Grid",
            "Small Checker Board",
            "Large Checker Board",
            "Outlined Diamond",
            "Solid Diamond"});
            this.backgroundPatternComboBox.Location = new System.Drawing.Point(133, 172);
            this.backgroundPatternComboBox.Name = "backgroundPatternComboBox";
            this.backgroundPatternComboBox.Size = new System.Drawing.Size(181, 21);
            this.backgroundPatternComboBox.TabIndex = 14;
            // 
            // alternateBackgroundPictureBox
            // 
            this.alternateBackgroundPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alternateBackgroundPictureBox.BackColor = System.Drawing.Color.IndianRed;
            this.alternateBackgroundPictureBox.Location = new System.Drawing.Point(133, 143);
            this.alternateBackgroundPictureBox.Name = "alternateBackgroundPictureBox";
            this.alternateBackgroundPictureBox.Size = new System.Drawing.Size(23, 23);
            this.alternateBackgroundPictureBox.TabIndex = 5;
            this.alternateBackgroundPictureBox.TabStop = false;
            // 
            // fillTypeComboBox
            // 
            this.fillTypeComboBox.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel2.SetColumnSpan(this.fillTypeComboBox, 2);
            this.fillTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.fillTypeComboBox.FormattingEnabled = true;
            this.fillTypeComboBox.Items.AddRange(new object[] {
            "Solid Color",
            "Hatch Fill",
            "Image",
            "Vertical Gradient",
            "Horizontal Gradient",
            "Diagonal Gradient UL/LR",
            "Diagonal Gradient UR/LL"});
            this.fillTypeComboBox.Location = new System.Drawing.Point(133, 116);
            this.fillTypeComboBox.Name = "fillTypeComboBox";
            this.fillTypeComboBox.Size = new System.Drawing.Size(181, 21);
            this.fillTypeComboBox.TabIndex = 12;
            // 
            // backgroundColorPictureBox
            // 
            this.backgroundColorPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backgroundColorPictureBox.BackColor = System.Drawing.Color.Gold;
            this.backgroundColorPictureBox.Location = new System.Drawing.Point(133, 87);
            this.backgroundColorPictureBox.Name = "backgroundColorPictureBox";
            this.backgroundColorPictureBox.Size = new System.Drawing.Size(23, 23);
            this.backgroundColorPictureBox.TabIndex = 4;
            this.backgroundColorPictureBox.TabStop = false;
            // 
            // borderColorPictureBox
            // 
            this.borderColorPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borderColorPictureBox.BackColor = System.Drawing.Color.DarkRed;
            this.borderColorPictureBox.Location = new System.Drawing.Point(133, 58);
            this.borderColorPictureBox.Name = "borderColorPictureBox";
            this.borderColorPictureBox.Size = new System.Drawing.Size(23, 23);
            this.borderColorPictureBox.TabIndex = 8;
            this.borderColorPictureBox.TabStop = false;
            // 
            // backgroundImageButton
            // 
            this.backgroundImageButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundImageButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.backgroundImageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.backgroundImageButton.Location = new System.Drawing.Point(12, 246);
            this.backgroundImageButton.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.backgroundImageButton.Name = "backgroundImageButton";
            this.backgroundImageButton.Size = new System.Drawing.Size(115, 23);
            this.backgroundImageButton.TabIndex = 9;
            this.backgroundImageButton.Text = "Background Image";
            this.backgroundImageButton.UseVisualStyleBackColor = false;
            // 
            // backgroundPatternLabel
            // 
            this.backgroundPatternLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundPatternLabel.AutoSize = true;
            this.backgroundPatternLabel.ForeColor = System.Drawing.Color.White;
            this.backgroundPatternLabel.Location = new System.Drawing.Point(25, 176);
            this.backgroundPatternLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.backgroundPatternLabel.Name = "backgroundPatternLabel";
            this.backgroundPatternLabel.Size = new System.Drawing.Size(105, 13);
            this.backgroundPatternLabel.TabIndex = 13;
            this.backgroundPatternLabel.Text = "Background Pattern:";
            // 
            // fillTypeLabel
            // 
            this.fillTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fillTypeLabel.AutoSize = true;
            this.fillTypeLabel.ForeColor = System.Drawing.Color.White;
            this.fillTypeLabel.Location = new System.Drawing.Point(81, 120);
            this.fillTypeLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.fillTypeLabel.Name = "fillTypeLabel";
            this.fillTypeLabel.Size = new System.Drawing.Size(49, 13);
            this.fillTypeLabel.TabIndex = 11;
            this.fillTypeLabel.Text = "Fill Type:";
            // 
            // imageWrapLabel
            // 
            this.imageWrapLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imageWrapLabel.AutoSize = true;
            this.imageWrapLabel.ForeColor = System.Drawing.Color.White;
            this.imageWrapLabel.Location = new System.Drawing.Point(23, 327);
            this.imageWrapLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.imageWrapLabel.Name = "imageWrapLabel";
            this.imageWrapLabel.Size = new System.Drawing.Size(107, 13);
            this.imageWrapLabel.TabIndex = 15;
            this.imageWrapLabel.Text = "Image Wrap Method:";
            // 
            // imageWrapComboBox
            // 
            this.imageWrapComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageWrapComboBox.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel2.SetColumnSpan(this.imageWrapComboBox, 2);
            this.imageWrapComboBox.ForeColor = System.Drawing.Color.Black;
            this.imageWrapComboBox.FormattingEnabled = true;
            this.imageWrapComboBox.Items.AddRange(new object[] {
            "Tile",
            "Tile Flip X",
            "Tile Flip Y",
            "Tile Flip X & Y",
            "Clamp"});
            this.imageWrapComboBox.Location = new System.Drawing.Point(133, 323);
            this.imageWrapComboBox.Name = "imageWrapComboBox";
            this.imageWrapComboBox.Size = new System.Drawing.Size(181, 21);
            this.imageWrapComboBox.TabIndex = 16;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(100, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel2.SetColumnSpan(this.titleTextBox, 2);
            this.titleTextBox.ForeColor = System.Drawing.Color.Black;
            this.titleTextBox.Location = new System.Drawing.Point(133, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(181, 20);
            this.titleTextBox.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.okButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(146, 347);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(177, 29);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.cancelButton.Location = new System.Drawing.Point(93, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.okButton.Location = new System.Drawing.Point(12, 3);
            this.okButton.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // foreColorComboBox
            // 
            this.foreColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foreColorComboBox.FormattingEnabled = true;
            this.foreColorComboBox.Location = new System.Drawing.Point(162, 29);
            this.foreColorComboBox.Name = "foreColorComboBox";
            this.foreColorComboBox.Size = new System.Drawing.Size(152, 21);
            this.foreColorComboBox.TabIndex = 24;
            // 
            // borderColorComboBox
            // 
            this.borderColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderColorComboBox.FormattingEnabled = true;
            this.borderColorComboBox.Location = new System.Drawing.Point(162, 58);
            this.borderColorComboBox.Name = "borderColorComboBox";
            this.borderColorComboBox.Size = new System.Drawing.Size(152, 21);
            this.borderColorComboBox.TabIndex = 25;
            // 
            // backgroundColor1ComboBox
            // 
            this.backgroundColor1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundColor1ComboBox.FormattingEnabled = true;
            this.backgroundColor1ComboBox.Location = new System.Drawing.Point(162, 87);
            this.backgroundColor1ComboBox.Name = "backgroundColor1ComboBox";
            this.backgroundColor1ComboBox.Size = new System.Drawing.Size(152, 21);
            this.backgroundColor1ComboBox.TabIndex = 26;
            // 
            // backgroundColor2ComboBox
            // 
            this.backgroundColor2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundColor2ComboBox.FormattingEnabled = true;
            this.backgroundColor2ComboBox.Location = new System.Drawing.Point(162, 143);
            this.backgroundColor2ComboBox.Name = "backgroundColor2ComboBox";
            this.backgroundColor2ComboBox.Size = new System.Drawing.Size(152, 21);
            this.backgroundColor2ComboBox.TabIndex = 27;
            // 
            // foreColorLabel
            // 
            this.foreColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.foreColorLabel.AutoSize = true;
            this.foreColorLabel.ForeColor = System.Drawing.Color.White;
            this.foreColorLabel.Location = new System.Drawing.Point(39, 34);
            this.foreColorLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.foreColorLabel.Name = "foreColorLabel";
            this.foreColorLabel.Size = new System.Drawing.Size(91, 13);
            this.foreColorLabel.TabIndex = 28;
            this.foreColorLabel.Text = "Foreground Color:";
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.borderColorLabel.AutoSize = true;
            this.borderColorLabel.ForeColor = System.Drawing.Color.White;
            this.borderColorLabel.Location = new System.Drawing.Point(62, 63);
            this.borderColorLabel.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(68, 13);
            this.borderColorLabel.TabIndex = 29;
            this.borderColorLabel.Text = "Border Color:";
            // 
            // backgroundColor1label
            // 
            this.backgroundColor1label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundColor1label.AutoSize = true;
            this.backgroundColor1label.ForeColor = System.Drawing.Color.White;
            this.backgroundColor1label.Location = new System.Drawing.Point(35, 92);
            this.backgroundColor1label.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.backgroundColor1label.Name = "backgroundColor1label";
            this.backgroundColor1label.Size = new System.Drawing.Size(95, 13);
            this.backgroundColor1label.TabIndex = 30;
            this.backgroundColor1label.Text = "Background Color:";
            // 
            // backgroundColor2Label
            // 
            this.backgroundColor2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backgroundColor2Label.AutoSize = true;
            this.backgroundColor2Label.ForeColor = System.Drawing.Color.White;
            this.backgroundColor2Label.Location = new System.Drawing.Point(17, 148);
            this.backgroundColor2Label.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.backgroundColor2Label.Name = "backgroundColor2Label";
            this.backgroundColor2Label.Size = new System.Drawing.Size(113, 13);
            this.backgroundColor2Label.TabIndex = 31;
            this.backgroundColor2Label.Text = "Alternate Background:";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(572, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(580, 440);
            this.Name = "SetupForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Initial Setup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternateBackgroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorPictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Erwine.Leonard.Thomas.WindowsFormsControls.TextCard sampleDeckTextCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox foregroundPictureBox;
        private System.Windows.Forms.PictureBox backgroundColorPictureBox;
        private System.Windows.Forms.PictureBox alternateBackgroundPictureBox;
        private System.Windows.Forms.PictureBox borderColorPictureBox;
        private System.Windows.Forms.Button backgroundImageButton;
        private System.Windows.Forms.PictureBox backgroundImagePictureBox;
        private System.Windows.Forms.Label fillTypeLabel;
        private System.Windows.Forms.ComboBox fillTypeComboBox;
        private System.Windows.Forms.Label backgroundPatternLabel;
        private System.Windows.Forms.ComboBox backgroundPatternComboBox;
        private System.Windows.Forms.Label imageWrapLabel;
        private System.Windows.Forms.ComboBox imageWrapComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Erwine.Leonard.Thomas.Flash_Cards.Data.Deck deck1;
        private System.Windows.Forms.ComboBox foreColorComboBox;
        private System.Windows.Forms.ComboBox borderColorComboBox;
        private System.Windows.Forms.ComboBox backgroundColor1ComboBox;
        private System.Windows.Forms.ComboBox backgroundColor2ComboBox;
        private System.Windows.Forms.Label foreColorLabel;
        private System.Windows.Forms.Label borderColorLabel;
        private System.Windows.Forms.Label backgroundColor1label;
        private System.Windows.Forms.Label backgroundColor2Label;

    }
}