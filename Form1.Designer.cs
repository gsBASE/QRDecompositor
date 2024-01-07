using System.Drawing;
using System.Windows.Forms;

namespace QR472
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.entryLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.e_TextBox11 = new System.Windows.Forms.TextBox();
            this.e_TextBox33 = new System.Windows.Forms.TextBox();
            this.e_TextBox32 = new System.Windows.Forms.TextBox();
            this.e_TextBox31 = new System.Windows.Forms.TextBox();
            this.e_TextBox23 = new System.Windows.Forms.TextBox();
            this.e_TextBox22 = new System.Windows.Forms.TextBox();
            this.e_TextBox21 = new System.Windows.Forms.TextBox();
            this.e_TextBox13 = new System.Windows.Forms.TextBox();
            this.e_TextBox12 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.decomposeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.rLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.r33 = new System.Windows.Forms.TextBox();
            this.r32 = new System.Windows.Forms.TextBox();
            this.r31 = new System.Windows.Forms.TextBox();
            this.r23 = new System.Windows.Forms.TextBox();
            this.r22 = new System.Windows.Forms.TextBox();
            this.r21 = new System.Windows.Forms.TextBox();
            this.r13 = new System.Windows.Forms.TextBox();
            this.r12 = new System.Windows.Forms.TextBox();
            this.r11 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.qLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.q33 = new System.Windows.Forms.TextBox();
            this.q23 = new System.Windows.Forms.TextBox();
            this.q13 = new System.Windows.Forms.TextBox();
            this.q32 = new System.Windows.Forms.TextBox();
            this.q22 = new System.Windows.Forms.TextBox();
            this.q12 = new System.Windows.Forms.TextBox();
            this.q21 = new System.Windows.Forms.TextBox();
            this.q11 = new System.Windows.Forms.TextBox();
            this.q31 = new System.Windows.Forms.TextBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entryLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.rLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.qLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryLayoutPanel
            // 
            this.entryLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.entryLayoutPanel.ColumnCount = 3;
            this.entryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.entryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.entryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.entryLayoutPanel.Controls.Add(this.e_TextBox11, 0, 0);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox33, 2, 2);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox32, 1, 2);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox31, 0, 2);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox23, 2, 1);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox22, 1, 1);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox21, 0, 1);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox13, 2, 0);
            this.entryLayoutPanel.Controls.Add(this.e_TextBox12, 1, 0);
            this.entryLayoutPanel.Location = new System.Drawing.Point(9, 52);
            this.entryLayoutPanel.Name = "entryLayoutPanel";
            this.entryLayoutPanel.RowCount = 3;
            this.entryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.entryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.entryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.entryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.entryLayoutPanel.Size = new System.Drawing.Size(219, 222);
            this.entryLayoutPanel.TabIndex = 50;
            this.entryLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.entryLayoutPanel_CellPaint);
            this.entryLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.entryLayoutPanel_Paint);
            // 
            // e_TextBox11
            // 
            this.e_TextBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox11.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox11.Location = new System.Drawing.Point(3, 27);
            this.e_TextBox11.Name = "e_TextBox11";
            this.e_TextBox11.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox11.TabIndex = 0;
            this.e_TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox33
            // 
            this.e_TextBox33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox33.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox33.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox33.Location = new System.Drawing.Point(149, 175);
            this.e_TextBox33.Name = "e_TextBox33";
            this.e_TextBox33.Size = new System.Drawing.Size(68, 20);
            this.e_TextBox33.TabIndex = 8;
            this.e_TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox32
            // 
            this.e_TextBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox32.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox32.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox32.Location = new System.Drawing.Point(76, 175);
            this.e_TextBox32.Name = "e_TextBox32";
            this.e_TextBox32.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox32.TabIndex = 7;
            this.e_TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox31
            // 
            this.e_TextBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox31.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox31.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox31.Location = new System.Drawing.Point(3, 175);
            this.e_TextBox31.Name = "e_TextBox31";
            this.e_TextBox31.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox31.TabIndex = 6;
            this.e_TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox23
            // 
            this.e_TextBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox23.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox23.Location = new System.Drawing.Point(149, 101);
            this.e_TextBox23.Name = "e_TextBox23";
            this.e_TextBox23.Size = new System.Drawing.Size(68, 20);
            this.e_TextBox23.TabIndex = 5;
            this.e_TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox22
            // 
            this.e_TextBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox22.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox22.Location = new System.Drawing.Point(76, 101);
            this.e_TextBox22.Name = "e_TextBox22";
            this.e_TextBox22.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox22.TabIndex = 4;
            this.e_TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox21
            // 
            this.e_TextBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox21.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox21.Location = new System.Drawing.Point(3, 101);
            this.e_TextBox21.Name = "e_TextBox21";
            this.e_TextBox21.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox21.TabIndex = 3;
            this.e_TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox13
            // 
            this.e_TextBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox13.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox13.Location = new System.Drawing.Point(149, 27);
            this.e_TextBox13.Name = "e_TextBox13";
            this.e_TextBox13.Size = new System.Drawing.Size(68, 20);
            this.e_TextBox13.TabIndex = 2;
            this.e_TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // e_TextBox12
            // 
            this.e_TextBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.e_TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.e_TextBox12.ForeColor = System.Drawing.Color.Black;
            this.e_TextBox12.Location = new System.Drawing.Point(76, 27);
            this.e_TextBox12.Name = "e_TextBox12";
            this.e_TextBox12.Size = new System.Drawing.Size(67, 20);
            this.e_TextBox12.TabIndex = 1;
            this.e_TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearButton.Location = new System.Drawing.Point(234, 65);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 45);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // decomposeButton
            // 
            this.decomposeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decomposeButton.Location = new System.Drawing.Point(301, 65);
            this.decomposeButton.Name = "decomposeButton";
            this.decomposeButton.Size = new System.Drawing.Size(103, 45);
            this.decomposeButton.TabIndex = 10;
            this.decomposeButton.Text = "Decompose";
            this.decomposeButton.UseVisualStyleBackColor = true;
            this.decomposeButton.Click += new System.EventHandler(this.decomposeButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox10.Location = new System.Drawing.Point(173, 60);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(79, 20);
            this.textBox10.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox11.Location = new System.Drawing.Point(88, 38);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(79, 20);
            this.textBox11.TabIndex = 7;
            // 
            // rLayoutPanel
            // 
            this.rLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.rLayoutPanel.ColumnCount = 3;
            this.rLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.rLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.rLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.rLayoutPanel.Controls.Add(this.r33, 2, 2);
            this.rLayoutPanel.Controls.Add(this.r32, 1, 2);
            this.rLayoutPanel.Controls.Add(this.r31, 0, 2);
            this.rLayoutPanel.Controls.Add(this.r23, 2, 1);
            this.rLayoutPanel.Controls.Add(this.r22, 1, 1);
            this.rLayoutPanel.Controls.Add(this.r21, 0, 1);
            this.rLayoutPanel.Controls.Add(this.r13, 2, 0);
            this.rLayoutPanel.Controls.Add(this.r12, 1, 0);
            this.rLayoutPanel.Controls.Add(this.r11, 0, 0);
            this.rLayoutPanel.Location = new System.Drawing.Point(633, 52);
            this.rLayoutPanel.Name = "rLayoutPanel";
            this.rLayoutPanel.RowCount = 3;
            this.rLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.rLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.rLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.rLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.rLayoutPanel.Size = new System.Drawing.Size(219, 222);
            this.rLayoutPanel.TabIndex = 50;
            this.rLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.rLayoutPanel_CellPaint);
            this.rLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rLayoutPanel_Paint);
            // 
            // r33
            // 
            this.r33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r33.BackColor = System.Drawing.SystemColors.Window;
            this.r33.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r33.Location = new System.Drawing.Point(149, 175);
            this.r33.Multiline = true;
            this.r33.Name = "r33";
            this.r33.ReadOnly = true;
            this.r33.Size = new System.Drawing.Size(68, 20);
            this.r33.TabIndex = 29;
            // 
            // r32
            // 
            this.r32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r32.BackColor = System.Drawing.SystemColors.Window;
            this.r32.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r32.Location = new System.Drawing.Point(76, 175);
            this.r32.Multiline = true;
            this.r32.Name = "r32";
            this.r32.ReadOnly = true;
            this.r32.Size = new System.Drawing.Size(67, 20);
            this.r32.TabIndex = 28;
            // 
            // r31
            // 
            this.r31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r31.BackColor = System.Drawing.SystemColors.Window;
            this.r31.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r31.Location = new System.Drawing.Point(3, 175);
            this.r31.Multiline = true;
            this.r31.Name = "r31";
            this.r31.ReadOnly = true;
            this.r31.Size = new System.Drawing.Size(67, 20);
            this.r31.TabIndex = 27;
            // 
            // r23
            // 
            this.r23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r23.BackColor = System.Drawing.SystemColors.Window;
            this.r23.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r23.Location = new System.Drawing.Point(149, 101);
            this.r23.Multiline = true;
            this.r23.Name = "r23";
            this.r23.ReadOnly = true;
            this.r23.Size = new System.Drawing.Size(68, 20);
            this.r23.TabIndex = 26;
            // 
            // r22
            // 
            this.r22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r22.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r22.Location = new System.Drawing.Point(76, 101);
            this.r22.Multiline = true;
            this.r22.Name = "r22";
            this.r22.ReadOnly = true;
            this.r22.Size = new System.Drawing.Size(67, 20);
            this.r22.TabIndex = 25;
            // 
            // r21
            // 
            this.r21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r21.BackColor = System.Drawing.SystemColors.Window;
            this.r21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r21.Location = new System.Drawing.Point(3, 101);
            this.r21.Multiline = true;
            this.r21.Name = "r21";
            this.r21.ReadOnly = true;
            this.r21.Size = new System.Drawing.Size(67, 20);
            this.r21.TabIndex = 24;
            // 
            // r13
            // 
            this.r13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r13.BackColor = System.Drawing.SystemColors.Window;
            this.r13.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r13.Location = new System.Drawing.Point(149, 27);
            this.r13.Multiline = true;
            this.r13.Name = "r13";
            this.r13.ReadOnly = true;
            this.r13.Size = new System.Drawing.Size(68, 20);
            this.r13.TabIndex = 23;
            // 
            // r12
            // 
            this.r12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r12.BackColor = System.Drawing.SystemColors.Window;
            this.r12.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r12.Location = new System.Drawing.Point(76, 27);
            this.r12.Multiline = true;
            this.r12.Name = "r12";
            this.r12.ReadOnly = true;
            this.r12.Size = new System.Drawing.Size(67, 20);
            this.r12.TabIndex = 21;
            // 
            // r11
            // 
            this.r11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.r11.BackColor = System.Drawing.SystemColors.Window;
            this.r11.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.r11.Location = new System.Drawing.Point(3, 27);
            this.r11.Multiline = true;
            this.r11.Name = "r11";
            this.r11.ReadOnly = true;
            this.r11.Size = new System.Drawing.Size(67, 20);
            this.r11.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.33334F));
            this.tableLayoutPanel5.Controls.Add(this.textBox21, 2, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox21.Location = new System.Drawing.Point(173, 60);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(79, 20);
            this.textBox21.TabIndex = 8;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox22.Location = new System.Drawing.Point(88, 38);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(79, 20);
            this.textBox22.TabIndex = 7;
            // 
            // qLayoutPanel
            // 
            this.qLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.qLayoutPanel.ColumnCount = 3;
            this.qLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.qLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.qLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.qLayoutPanel.Controls.Add(this.q33, 2, 2);
            this.qLayoutPanel.Controls.Add(this.q23, 1, 2);
            this.qLayoutPanel.Controls.Add(this.q13, 0, 2);
            this.qLayoutPanel.Controls.Add(this.q32, 2, 1);
            this.qLayoutPanel.Controls.Add(this.q22, 1, 1);
            this.qLayoutPanel.Controls.Add(this.q12, 0, 1);
            this.qLayoutPanel.Controls.Add(this.q21, 1, 0);
            this.qLayoutPanel.Controls.Add(this.q11, 0, 0);
            this.qLayoutPanel.Controls.Add(this.q31, 2, 0);
            this.qLayoutPanel.Location = new System.Drawing.Point(409, 52);
            this.qLayoutPanel.Name = "qLayoutPanel";
            this.qLayoutPanel.RowCount = 3;
            this.qLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.qLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.qLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.qLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.qLayoutPanel.Size = new System.Drawing.Size(219, 222);
            this.qLayoutPanel.TabIndex = 50;
            this.qLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.qLayoutPanel_CellPaint);
            this.qLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.qLayoutPanel_Paint);
            // 
            // q33
            // 
            this.q33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q33.BackColor = System.Drawing.SystemColors.Window;
            this.q33.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q33.Location = new System.Drawing.Point(149, 175);
            this.q33.Multiline = true;
            this.q33.Name = "q33";
            this.q33.ReadOnly = true;
            this.q33.Size = new System.Drawing.Size(68, 20);
            this.q33.TabIndex = 19;
            // 
            // q23
            // 
            this.q23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q23.BackColor = System.Drawing.SystemColors.Window;
            this.q23.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q23.Location = new System.Drawing.Point(76, 175);
            this.q23.Multiline = true;
            this.q23.Name = "q23";
            this.q23.ReadOnly = true;
            this.q23.Size = new System.Drawing.Size(67, 20);
            this.q23.TabIndex = 18;
            // 
            // q13
            // 
            this.q13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q13.BackColor = System.Drawing.SystemColors.Window;
            this.q13.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q13.Location = new System.Drawing.Point(3, 175);
            this.q13.Multiline = true;
            this.q13.Name = "q13";
            this.q13.ReadOnly = true;
            this.q13.Size = new System.Drawing.Size(67, 20);
            this.q13.TabIndex = 17;
            // 
            // q32
            // 
            this.q32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q32.BackColor = System.Drawing.SystemColors.Window;
            this.q32.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q32.Location = new System.Drawing.Point(149, 101);
            this.q32.Multiline = true;
            this.q32.Name = "q32";
            this.q32.ReadOnly = true;
            this.q32.Size = new System.Drawing.Size(68, 20);
            this.q32.TabIndex = 16;
            // 
            // q22
            // 
            this.q22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q22.BackColor = System.Drawing.SystemColors.Window;
            this.q22.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q22.Location = new System.Drawing.Point(76, 101);
            this.q22.Multiline = true;
            this.q22.Name = "q22";
            this.q22.ReadOnly = true;
            this.q22.Size = new System.Drawing.Size(67, 20);
            this.q22.TabIndex = 15;
            // 
            // q12
            // 
            this.q12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q12.BackColor = System.Drawing.SystemColors.Window;
            this.q12.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q12.Location = new System.Drawing.Point(3, 101);
            this.q12.Multiline = true;
            this.q12.Name = "q12";
            this.q12.ReadOnly = true;
            this.q12.Size = new System.Drawing.Size(67, 20);
            this.q12.TabIndex = 14;
            // 
            // q21
            // 
            this.q21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q21.BackColor = System.Drawing.SystemColors.Window;
            this.q21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q21.Location = new System.Drawing.Point(76, 27);
            this.q21.Multiline = true;
            this.q21.Name = "q21";
            this.q21.ReadOnly = true;
            this.q21.Size = new System.Drawing.Size(67, 20);
            this.q21.TabIndex = 12;
            // 
            // q11
            // 
            this.q11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q11.BackColor = System.Drawing.SystemColors.Window;
            this.q11.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q11.Location = new System.Drawing.Point(3, 27);
            this.q11.Multiline = true;
            this.q11.Name = "q11";
            this.q11.ReadOnly = true;
            this.q11.Size = new System.Drawing.Size(67, 20);
            this.q11.TabIndex = 11;
            // 
            // q31
            // 
            this.q31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.q31.BackColor = System.Drawing.SystemColors.Window;
            this.q31.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.q31.Location = new System.Drawing.Point(149, 27);
            this.q31.Multiline = true;
            this.q31.Name = "q31";
            this.q31.ReadOnly = true;
            this.q31.Size = new System.Drawing.Size(68, 20);
            this.q31.TabIndex = 13;
            // 
            // errorTextBox
            // 
            this.errorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.errorTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.errorTextBox.Location = new System.Drawing.Point(234, 124);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(170, 150);
            this.errorTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(864, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.qLayoutPanel);
            this.Controls.Add(this.rLayoutPanel);
            this.Controls.Add(this.decomposeButton);
            this.Controls.Add(this.entryLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Decompositor";
            this.entryLayoutPanel.ResumeLayout(false);
            this.entryLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.rLayoutPanel.ResumeLayout(false);
            this.rLayoutPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.qLayoutPanel.ResumeLayout(false);
            this.qLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel entryLayoutPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox e_TextBox33;
        private TextBox e_TextBox32;
        private TextBox e_TextBox31;
        private TextBox e_TextBox23;
        private TextBox e_TextBox22;
        private TextBox e_TextBox21;
        private TextBox e_TextBox13;
        private TextBox e_TextBox12;
        private Button decomposeButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox10;
        private TextBox textBox11;
        private TableLayoutPanel rLayoutPanel;
        private TextBox r33;
        private TextBox r32;
        private TextBox r31;
        private TextBox r23;
        private TextBox r22;
        private TextBox r21;
        private TextBox r13;
        private TextBox r12;
        private TextBox r11;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox21;
        private TextBox textBox22;
        private TableLayoutPanel qLayoutPanel;
        private TextBox q33;
        private TextBox q23;
        private TextBox q13;
        private TextBox q32;
        private TextBox q22;
        private TextBox q12;
        private TextBox q31;
        private TextBox q21;
        private TextBox q11;
        private TextBox errorTextBox;
        private TextBox e_TextBox11;
        private Button clearButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}