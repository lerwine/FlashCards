namespace Erwine.Leonard.Thomas.Flash_Cards
{
    partial class CardTableForm
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
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textCardDeck = new Erwine.Leonard.Thomas.WindowsFormsControls.TextCard();
            this.textCardDisplay = new Erwine.Leonard.Thomas.WindowsFormsControls.TextCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.cardsInDeckLabel = new System.Windows.Forms.Label();
            this.cardsPlayedLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.setupToolStripMenuItem.Text = "&Setup";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.textCardDeck, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textCardDisplay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 520);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textCardDeck
            // 
            this.textCardDeck.BackColor = System.Drawing.Color.Transparent;
            this.textCardDeck.BackColor1 = System.Drawing.Color.ForestGreen;
            this.textCardDeck.BackColor2 = System.Drawing.Color.DarkGreen;
            this.textCardDeck.CardBorderColor = System.Drawing.Color.DarkGreen;
            this.textCardDeck.CardBorderWidth = 0;
            this.textCardDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCardDeck.FillType = Erwine.Leonard.Thomas.WindowsFormsControls.TextCard.FillTypeEnum.HatchFill;
            this.textCardDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardDeck.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeConfetti;
            this.textCardDeck.Location = new System.Drawing.Point(4, 5);
            this.textCardDeck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCardDeck.Name = "textCardDeck";
            this.textCardDeck.Size = new System.Drawing.Size(110, 156);
            this.textCardDeck.TabIndex = 0;
            this.textCardDeck.Texture = null;
            this.textCardDeck.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            // 
            // textCardDisplay
            // 
            this.textCardDisplay.BackColor = System.Drawing.Color.Transparent;
            this.textCardDisplay.BackColor1 = System.Drawing.Color.ForestGreen;
            this.textCardDisplay.BackColor2 = System.Drawing.Color.DarkGreen;
            this.textCardDisplay.CardBorderColor = System.Drawing.Color.DarkGreen;
            this.textCardDisplay.CardBorderWidth = 4;
            this.textCardDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCardDisplay.FillType = Erwine.Leonard.Thomas.WindowsFormsControls.TextCard.FillTypeEnum.HatchFill;
            this.textCardDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardDisplay.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeConfetti;
            this.textCardDisplay.Location = new System.Drawing.Point(122, 5);
            this.textCardDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCardDisplay.Name = "textCardDisplay";
            this.tableLayoutPanel1.SetRowSpan(this.textCardDisplay, 2);
            this.textCardDisplay.Size = new System.Drawing.Size(308, 510);
            this.textCardDisplay.TabIndex = 1;
            this.textCardDisplay.Texture = global::Erwine.Leonard.Thomas.Flash_Cards.Properties.Resources.P1000077;
            this.textCardDisplay.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.deckNameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cardsInDeckLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cardsPlayedLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.correctLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.percentageLabel, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(434, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 520);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deck Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cards In Deck:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cards Played:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correct:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Percentage:";
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckNameLabel.ForeColor = System.Drawing.Color.White;
            this.deckNameLabel.Location = new System.Drawing.Point(93, 0);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(27, 13);
            this.deckNameLabel.TabIndex = 5;
            this.deckNameLabel.Text = "n/a";
            // 
            // cardsInDeckLabel
            // 
            this.cardsInDeckLabel.AutoSize = true;
            this.cardsInDeckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsInDeckLabel.ForeColor = System.Drawing.Color.White;
            this.cardsInDeckLabel.Location = new System.Drawing.Point(93, 25);
            this.cardsInDeckLabel.Name = "cardsInDeckLabel";
            this.cardsInDeckLabel.Size = new System.Drawing.Size(27, 13);
            this.cardsInDeckLabel.TabIndex = 6;
            this.cardsInDeckLabel.Text = "n/a";
            // 
            // cardsPlayedLabel
            // 
            this.cardsPlayedLabel.AutoSize = true;
            this.cardsPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsPlayedLabel.ForeColor = System.Drawing.Color.White;
            this.cardsPlayedLabel.Location = new System.Drawing.Point(93, 50);
            this.cardsPlayedLabel.Name = "cardsPlayedLabel";
            this.cardsPlayedLabel.Size = new System.Drawing.Size(27, 13);
            this.cardsPlayedLabel.TabIndex = 7;
            this.cardsPlayedLabel.Text = "n/a";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(93, 75);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(27, 13);
            this.correctLabel.TabIndex = 8;
            this.correctLabel.Text = "n/a";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.ForeColor = System.Drawing.Color.White;
            this.percentageLabel.Location = new System.Drawing.Point(93, 100);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(27, 13);
            this.percentageLabel.TabIndex = 9;
            this.percentageLabel.Text = "n/a";
            // 
            // CardTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CardTableForm";
            this.Text = "Flash Cards";
            this.Shown += new System.EventHandler(this.CardTableForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Erwine.Leonard.Thomas.WindowsFormsControls.TextCard textCardDeck;
        private Erwine.Leonard.Thomas.WindowsFormsControls.TextCard textCardDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.Label cardsInDeckLabel;
        private System.Windows.Forms.Label cardsPlayedLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;


    }
}