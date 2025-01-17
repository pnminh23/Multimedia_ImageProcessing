namespace Multimedia_ImageProcessing
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            tb_thongSo = new TextBox();
            lbl_thongSo = new Label();
            contrastTracker = new TrackBar();
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            openTSMI = new ToolStripMenuItem();
            saveTSMI = new ToolStripMenuItem();
            fomatTSMI = new ToolStripMenuItem();
            chỉnhSửaToolStripMenuItem = new ToolStripMenuItem();
            brightnessTSMI = new ToolStripMenuItem();
            blurTSMI = new ToolStripMenuItem();
            colorTSMI = new ToolStripMenuItem();
            contrastTSMI = new ToolStripMenuItem();
            removeBkgSTMI = new ToolStripMenuItem();
            collageTSMI = new ToolStripMenuItem();
            rotateSTMI = new ToolStripMenuItem();
            flipTSMI = new ToolStripMenuItem();
            frameTSMI = new ToolStripMenuItem();
            cutTSMI = new ToolStripMenuItem();
            thaoTácToolStripMenuItem = new ToolStripMenuItem();
            undoTSMI = new ToolStripMenuItem();
            redoTSMI = new ToolStripMenuItem();
            presentTSMI = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            btn_apDung = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            btn_redo = new Button();
            btn_undo = new Button();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTracker).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 37);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa ảnh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(191, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 500);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ảnh";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Image_not_found;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(6, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(797, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 193);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Định dạng";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Kích thước ảnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "Đưỡng dẫn ảnh";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(tb_thongSo);
            groupBox3.Controls.Add(lbl_thongSo);
            groupBox3.Controls.Add(contrastTracker);
            groupBox3.Location = new Point(12, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(173, 181);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tuỳ chỉnh";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Chọn kích cỡ khung", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            comboBox3.Location = new Point(6, 152);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(161, 23);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Chọn màu", "black", "white", "red", "green", "blue", "yellow", "cyan", "magenta" });
            comboBox2.Location = new Point(6, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tb_thongSo
            // 
            tb_thongSo.Location = new Point(6, 50);
            tb_thongSo.Name = "tb_thongSo";
            tb_thongSo.Size = new Size(161, 23);
            tb_thongSo.TabIndex = 10;
            tb_thongSo.TextChanged += tb_thongSo_TextChanged_1;
            // 
            // lbl_thongSo
            // 
            lbl_thongSo.AutoSize = true;
            lbl_thongSo.Location = new Point(6, 32);
            lbl_thongSo.Name = "lbl_thongSo";
            lbl_thongSo.Size = new Size(56, 15);
            lbl_thongSo.TabIndex = 9;
            lbl_thongSo.Text = "Thông số";
            // 
            // contrastTracker
            // 
            contrastTracker.LargeChange = 1;
            contrastTracker.Location = new Point(6, 50);
            contrastTracker.Maximum = 20;
            contrastTracker.Name = "contrastTracker";
            contrastTracker.Size = new Size(161, 45);
            contrastTracker.TabIndex = 9;
            contrastTracker.Value = 10;
            contrastTracker.Scroll += contrastTracker_Scroll;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, chỉnhSửaToolStripMenuItem, thaoTácToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openTSMI, saveTSMI, fomatTSMI });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(38, 20);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // openTSMI
            // 
            openTSMI.Name = "openTSMI";
            openTSMI.Size = new Size(149, 22);
            openTSMI.Text = "Mở";
            openTSMI.Click += openTSMI_Click;
            // 
            // saveTSMI
            // 
            saveTSMI.Name = "saveTSMI";
            saveTSMI.Size = new Size(149, 22);
            saveTSMI.Text = "Lưu";
            saveTSMI.Click += saveTSMI_Click;
            // 
            // fomatTSMI
            // 
            fomatTSMI.Name = "fomatTSMI";
            fomatTSMI.Size = new Size(149, 22);
            fomatTSMI.Text = "Đổi định dạng";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { brightnessTSMI, blurTSMI, colorTSMI, contrastTSMI, removeBkgSTMI, collageTSMI, rotateSTMI, flipTSMI, frameTSMI, cutTSMI });
            chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            chỉnhSửaToolStripMenuItem.Size = new Size(72, 20);
            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // brightnessTSMI
            // 
            brightnessTSMI.Name = "brightnessTSMI";
            brightnessTSMI.Size = new Size(188, 22);
            brightnessTSMI.Text = "Chỉnh độ sáng";
            // 
            // blurTSMI
            // 
            blurTSMI.Name = "blurTSMI";
            blurTSMI.Size = new Size(188, 22);
            blurTSMI.Text = "Làm mờ";
            // 
            // colorTSMI
            // 
            colorTSMI.Name = "colorTSMI";
            colorTSMI.Size = new Size(188, 22);
            colorTSMI.Text = "Chỉnh màu";
            // 
            // contrastTSMI
            // 
            contrastTSMI.Name = "contrastTSMI";
            contrastTSMI.Size = new Size(188, 22);
            contrastTSMI.Text = "Chỉnh độ tương phản";
            // 
            // removeBkgSTMI
            // 
            removeBkgSTMI.Name = "removeBkgSTMI";
            removeBkgSTMI.Size = new Size(188, 22);
            removeBkgSTMI.Text = "Xoá phông";
            // 
            // collageTSMI
            // 
            collageTSMI.Name = "collageTSMI";
            collageTSMI.Size = new Size(188, 22);
            collageTSMI.Text = "Ghép ảnh";
            // 
            // rotateSTMI
            // 
            rotateSTMI.Name = "rotateSTMI";
            rotateSTMI.Size = new Size(188, 22);
            rotateSTMI.Text = "Xoay ảnh";
            // 
            // flipTSMI
            // 
            flipTSMI.Name = "flipTSMI";
            flipTSMI.Size = new Size(188, 22);
            flipTSMI.Text = "Lật ảnh";
            // 
            // frameTSMI
            // 
            frameTSMI.Name = "frameTSMI";
            frameTSMI.Size = new Size(188, 22);
            frameTSMI.Text = "Thêm khung ảnh";
            // 
            // cutTSMI
            // 
            cutTSMI.Name = "cutTSMI";
            cutTSMI.Size = new Size(188, 22);
            cutTSMI.Text = "Cắt ảnh";
            // 
            // thaoTácToolStripMenuItem
            // 
            thaoTácToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoTSMI, redoTSMI, presentTSMI });
            thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            thaoTácToolStripMenuItem.Size = new Size(64, 20);
            thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // undoTSMI
            // 
            undoTSMI.Name = "undoTSMI";
            undoTSMI.Size = new Size(180, 22);
            undoTSMI.Text = "Hoàn tác";
            undoTSMI.Click += undoTSMI_Click;
            // 
            // redoTSMI
            // 
            redoTSMI.Name = "redoTSMI";
            redoTSMI.Size = new Size(180, 22);
            redoTSMI.Text = "Làm lại";
            redoTSMI.Click += redoTSMI_Click;
            // 
            // presentTSMI
            // 
            presentTSMI.Name = "presentTSMI";
            presentTSMI.Size = new Size(180, 22);
            presentTSMI.Text = "Ảnh đang chỉnh sửa";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_apDung
            // 
            btn_apDung.Location = new Point(85, 320);
            btn_apDung.Name = "btn_apDung";
            btn_apDung.Size = new Size(100, 30);
            btn_apDung.TabIndex = 4;
            btn_apDung.Text = "Áp dụng";
            btn_apDung.UseVisualStyleBackColor = true;
            btn_apDung.Click += btn_apDung_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "---Chọn chức năng---", "Chỉnh độ sáng", "Làm mờ", "Chỉnh màu", "Chỉnh độ tương phản", "Xoá phông", "Ghép ảnh", "Xoay ảnh", "Lật ảnh", "Thêm khung ảnh", "Cắt ảnh" });
            comboBox1.Location = new Point(12, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 80);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Chức năng";
            // 
            // btn_redo
            // 
            btn_redo.Location = new Point(913, 289);
            btn_redo.Name = "btn_redo";
            btn_redo.Size = new Size(50, 25);
            btn_redo.TabIndex = 10;
            btn_redo.Text = ">>";
            btn_redo.UseVisualStyleBackColor = true;
            btn_redo.Click += btn_redo_Click;
            // 
            // btn_undo
            // 
            btn_undo.ImageAlign = ContentAlignment.MiddleRight;
            btn_undo.Location = new Point(857, 289);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(50, 25);
            btn_undo.TabIndex = 11;
            btn_undo.Text = "<<";
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Click += btn_undo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 83);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 13;
            label6.Text = "Chọn màu";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 134);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 14;
            label7.Text = "Chọn kích cỡ khung";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 611);
            Controls.Add(btn_undo);
            Controls.Add(btn_redo);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btn_apDung);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Trình chỉnh sửa ảnh ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTracker).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MenuStrip menuStrip1;
        private OpenFileDialog openFileDialog;
        private Button btn_apDung;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lbl_thongSo;
        private ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private ToolStripMenuItem brightnessTSMI;
        private ToolStripMenuItem blurTSMI;
        private ToolStripMenuItem colorTSMI;
        private ToolStripMenuItem contrastTSMI;
        private ToolStripMenuItem removeBkgSTMI;
        private ToolStripMenuItem collageTSMI;
        private ToolStripMenuItem rotateSTMI;
        private ToolStripMenuItem flipTSMI;
        private ToolStripMenuItem frameTSMI;
        private ToolStripMenuItem cutTSMI;
        private ToolStripMenuItem thaoTácToolStripMenuItem;
        private ToolStripMenuItem undoTSMI;
        private ToolStripMenuItem redoTSMI;
        private ToolStripMenuItem presentTSMI;
        private TrackBar contrastTracker;
        private Button button1;
        private Button btn_redo;
        private Button btn_undo;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem openTSMI;
        private ToolStripMenuItem saveTSMI;
        private ToolStripMenuItem fomatTSMI;
        private TextBox tb_thongSo;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
    }
}