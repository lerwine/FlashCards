namespace FlashDeck
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shuffleSkippedCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeSkippedCardsAtEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextCard = new System.Windows.Forms.Button();
            this.buttonShowAnswer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deckToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckTitleToolStripMenuItem,
            this.addNewCardToolStripMenuItem,
            this.deleteCurrentCardToolStripMenuItem,
            this.editCurrentCardToolStripMenuItem,
            this.manageCardsToolStripMenuItem});
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.deckToolStripMenuItem.Text = "Card";
            // 
            // deckTitleToolStripMenuItem
            // 
            this.deckTitleToolStripMenuItem.Name = "deckTitleToolStripMenuItem";
            this.deckTitleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deckTitleToolStripMenuItem.Text = "Deck Title";
            // 
            // addNewCardToolStripMenuItem
            // 
            this.addNewCardToolStripMenuItem.Name = "addNewCardToolStripMenuItem";
            this.addNewCardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addNewCardToolStripMenuItem.Text = "Add New Card";
            // 
            // deleteCurrentCardToolStripMenuItem
            // 
            this.deleteCurrentCardToolStripMenuItem.Name = "deleteCurrentCardToolStripMenuItem";
            this.deleteCurrentCardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deleteCurrentCardToolStripMenuItem.Text = "Delete Current Card";
            // 
            // editCurrentCardToolStripMenuItem
            // 
            this.editCurrentCardToolStripMenuItem.Name = "editCurrentCardToolStripMenuItem";
            this.editCurrentCardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editCurrentCardToolStripMenuItem.Text = "Edit Current Card";
            // 
            // manageCardsToolStripMenuItem
            // 
            this.manageCardsToolStripMenuItem.Name = "manageCardsToolStripMenuItem";
            this.manageCardsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manageCardsToolStripMenuItem.Text = "Manage Cards";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startOverToolStripMenuItem,
            this.toolStripSeparator2,
            this.shuffleSkippedCardsToolStripMenuItem,
            this.placeSkippedCardsAtEndToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // startOverToolStripMenuItem
            // 
            this.startOverToolStripMenuItem.Name = "startOverToolStripMenuItem";
            this.startOverToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.startOverToolStripMenuItem.Text = "Start Over";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // shuffleSkippedCardsToolStripMenuItem
            // 
            this.shuffleSkippedCardsToolStripMenuItem.Checked = true;
            this.shuffleSkippedCardsToolStripMenuItem.CheckOnClick = true;
            this.shuffleSkippedCardsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shuffleSkippedCardsToolStripMenuItem.Name = "shuffleSkippedCardsToolStripMenuItem";
            this.shuffleSkippedCardsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.shuffleSkippedCardsToolStripMenuItem.Text = "Shuffle Skipped Cards back into deck";
            // 
            // placeSkippedCardsAtEndToolStripMenuItem
            // 
            this.placeSkippedCardsAtEndToolStripMenuItem.CheckOnClick = true;
            this.placeSkippedCardsAtEndToolStripMenuItem.Name = "placeSkippedCardsAtEndToolStripMenuItem";
            this.placeSkippedCardsAtEndToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.placeSkippedCardsAtEndToolStripMenuItem.Text = "Place Skipped Cards at end of deck";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonNextCard, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowAnswer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 442);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonNextCard
            // 
            this.buttonNextCard.Location = new System.Drawing.Point(249, 403);
            this.buttonNextCard.Name = "buttonNextCard";
            this.buttonNextCard.Size = new System.Drawing.Size(75, 23);
            this.buttonNextCard.TabIndex = 0;
            this.buttonNextCard.Text = "Next Card";
            this.buttonNextCard.UseVisualStyleBackColor = true;
            // 
            // buttonShowAnswer
            // 
            this.buttonShowAnswer.Location = new System.Drawing.Point(15, 403);
            this.buttonShowAnswer.Name = "buttonShowAnswer";
            this.buttonShowAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAnswer.TabIndex = 1;
            this.buttonShowAnswer.Text = "Show Answer";
            this.buttonShowAnswer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem shuffleSkippedCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeSkippedCardsAtEndToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNextCard;
        private System.Windows.Forms.Button buttonShowAnswer;
    }
}

