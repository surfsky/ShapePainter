using System;
using System.Windows.Forms;

namespace ShapePainter
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.RectButton = new System.Windows.Forms.Button();
            this.OvalButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RhombusButton = new System.Windows.Forms.Button();
            this.TriButton = new System.Windows.Forms.Button();
            this.StarButton = new System.Windows.Forms.Button();
            this.selectTool = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnText = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSavePic = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shapes";
            // 
            // RectButton
            // 
            this.RectButton.Location = new System.Drawing.Point(664, 52);
            this.RectButton.Margin = new System.Windows.Forms.Padding(2);
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(137, 26);
            this.RectButton.TabIndex = 4;
            this.RectButton.Text = "Rect";
            this.RectButton.UseVisualStyleBackColor = true;
            this.RectButton.Click += new System.EventHandler(this.RectButtonClicked);
            // 
            // OvalButton
            // 
            this.OvalButton.Location = new System.Drawing.Point(664, 82);
            this.OvalButton.Margin = new System.Windows.Forms.Padding(2);
            this.OvalButton.Name = "OvalButton";
            this.OvalButton.Size = new System.Drawing.Size(136, 28);
            this.OvalButton.TabIndex = 5;
            this.OvalButton.Text = "Oval";
            this.OvalButton.UseVisualStyleBackColor = true;
            this.OvalButton.Click += new System.EventHandler(this.OvalButtonClicked);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(664, 114);
            this.LineButton.Margin = new System.Windows.Forms.Padding(2);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(136, 25);
            this.LineButton.TabIndex = 6;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButtonClicked);
            // 
            // RhombusButton
            // 
            this.RhombusButton.Location = new System.Drawing.Point(664, 143);
            this.RhombusButton.Margin = new System.Windows.Forms.Padding(2);
            this.RhombusButton.Name = "RhombusButton";
            this.RhombusButton.Size = new System.Drawing.Size(136, 27);
            this.RhombusButton.TabIndex = 7;
            this.RhombusButton.Text = "Rhombus";
            this.RhombusButton.UseVisualStyleBackColor = true;
            this.RhombusButton.Click += new System.EventHandler(this.RhombusButtonClicked);
            // 
            // TriButton
            // 
            this.TriButton.Location = new System.Drawing.Point(664, 174);
            this.TriButton.Margin = new System.Windows.Forms.Padding(2);
            this.TriButton.Name = "TriButton";
            this.TriButton.Size = new System.Drawing.Size(136, 28);
            this.TriButton.TabIndex = 8;
            this.TriButton.Text = "Triangle";
            this.TriButton.UseVisualStyleBackColor = true;
            this.TriButton.Click += new System.EventHandler(this.TriButtonClicked);
            // 
            // StarButton
            // 
            this.StarButton.Location = new System.Drawing.Point(664, 206);
            this.StarButton.Margin = new System.Windows.Forms.Padding(2);
            this.StarButton.Name = "StarButton";
            this.StarButton.Size = new System.Drawing.Size(136, 27);
            this.StarButton.TabIndex = 9;
            this.StarButton.Text = "Star";
            this.StarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StarButton.UseVisualStyleBackColor = true;
            this.StarButton.Click += new System.EventHandler(this.StarButtonClicked);
            // 
            // selectTool
            // 
            this.selectTool.Location = new System.Drawing.Point(665, 416);
            this.selectTool.Margin = new System.Windows.Forms.Padding(2);
            this.selectTool.Name = "selectTool";
            this.selectTool.Size = new System.Drawing.Size(136, 27);
            this.selectTool.TabIndex = 10;
            this.selectTool.Text = "Select";
            this.selectTool.UseVisualStyleBackColor = true;
            this.selectTool.Click += new System.EventHandler(this.SelectTool_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnLoad,
            this.toolStripSeparator1,
            this.btnSavePic,
            this.toolStripSeparator2,
            this.btnUndo,
            this.btnRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(665, 237);
            this.btnText.Margin = new System.Windows.Forms.Padding(2);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(136, 27);
            this.btnText.TabIndex = 12;
            this.btnText.Text = "Text";
            this.btnText.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.BtnText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(41, 24);
            this.btnLoad.Text = "Load";
            this.btnLoad.ToolTipText = "Загрузить из файла";
            this.btnLoad.Click += new System.EventHandler(this.LoadButtonClicked);
            // 
            // btnSavePic
            // 
            this.btnSavePic.Image = global::ShapePainter.Properties.Resources.picture;
            this.btnSavePic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(98, 24);
            this.btnSavePic.Text = "SavePicture";
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::ShapePainter.Properties.Resources.arrow_turn_left;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(64, 24);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Image = global::ShapePainter.Properties.Resources.arrow_turn_right;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(63, 24);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 425);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelMousePressed);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseReleased);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 454);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.selectTool);
            this.Controls.Add(this.StarButton);
            this.Controls.Add(this.TriButton);
            this.Controls.Add(this.RhombusButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.OvalButton);
            this.Controls.Add(this.RectButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShapePainter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button RectButton;
        private Button OvalButton;
        private Button LineButton;
        private Button RhombusButton;
        private Button TriButton;
        private Button StarButton;
        private Button selectTool;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripButton btnLoad;
        private Button btnText;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnUndo;
        private ToolStripButton btnRedo;
        private ToolStripButton btnSavePic;
        private ToolStripSeparator toolStripSeparator2;
    }
}

