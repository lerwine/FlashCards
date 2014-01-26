using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.Flash_Cards
{
    public partial class SetupForm : Form
    {
        public SetupForm(Data.Deck deck)
        {
            Data.DropDownItem<Color>[] colors;

            InitializeComponent();

            this.deck1.Load(deck);

            this.titleTextBox.Text = this.deck1.Title;

            this.fillTypeComboBox.Items.Clear();

            foreach (Data.DropDownItem<WindowsFormsControls.TextCard.FillTypeEnum> item in
                    Data.Utility.GetDropDownItemList<WindowsFormsControls.TextCard.FillTypeEnum>("FillType"))
                this.fillTypeComboBox.Items.Add(item);

            this.backgroundPatternComboBox.Items.Clear();

            foreach (Data.DropDownItem<HatchStyle> item in Data.Utility.GetDropDownItemList<HatchStyle>("HatchStyle"))
                this.backgroundPatternComboBox.Items.Add(item);

            this.imageWrapComboBox.Items.Clear();

            foreach (Data.DropDownItem<WrapMode> item in Data.Utility.GetDropDownItemList<WrapMode>("WrapMode"))
                this.imageWrapComboBox.Items.Add(item);

            colors = Data.Utility.GetDropDownItemList<Color>("Color");

            this.foreColorComboBox.Items.Clear();

            foreach (Data.DropDownItem<Color> item in colors)
                this.foreColorComboBox.Items.Add(item);

            this.borderColorComboBox.Items.Clear();

            foreach (Data.DropDownItem<Color> item in colors)
                this.borderColorComboBox.Items.Add(item);

            this.backgroundColor1ComboBox.Items.Clear();

            foreach (Data.DropDownItem<Color> item in colors)
                this.backgroundColor1ComboBox.Items.Add(item);

            this.backgroundColor2ComboBox.Items.Clear();

            foreach (Data.DropDownItem<Color> item in colors)
                this.backgroundColor2ComboBox.Items.Add(item);
        }
    }
}
