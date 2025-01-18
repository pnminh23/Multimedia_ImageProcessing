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
            lbl_imgFormat = new Label();
            lbl_imgSize = new Label();
            lbl_imgAddress = new Label();
            groupBox3 = new GroupBox();
            comboBox4 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btn_rotateX = new Button();
            btn_rotateY = new Button();
            label7 = new Label();
            label6 = new Label();
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
            sobelTSMI = new ToolStripMenuItem();
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
            label1.Location = new Point(812, 79);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 57);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa ảnh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(355, 169);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1114, 1067);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ảnh";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Image_not_found;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(11, 45);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1092, 1009);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_imgFormat);
            groupBox2.Controls.Add(lbl_imgSize);
            groupBox2.Controls.Add(lbl_imgAddress);
            groupBox2.Location = new Point(1480, 169);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(418, 412);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin ảnh";
            // 
            // lbl_imgFormat
            // 
            lbl_imgFormat.AutoSize = true;
            lbl_imgFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_imgFormat.Location = new Point(20, 322);
            lbl_imgFormat.Margin = new Padding(6, 0, 6, 0);
            lbl_imgFormat.Name = "lbl_imgFormat";
            lbl_imgFormat.Size = new Size(133, 32);
            lbl_imgFormat.TabIndex = 7;
            lbl_imgFormat.Text = "Định dạng";
            lbl_imgFormat.Click += label4_Click;
            // 
            // lbl_imgSize
            // 
            lbl_imgSize.AutoSize = true;
            lbl_imgSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_imgSize.Location = new Point(20, 277);
            lbl_imgSize.Margin = new Padding(6, 0, 6, 0);
            lbl_imgSize.Name = "lbl_imgSize";
            lbl_imgSize.Size = new Size(185, 32);
            lbl_imgSize.TabIndex = 6;
            lbl_imgSize.Text = "Kích thước ảnh";
            // 
            // lbl_imgAddress
            // 
            lbl_imgAddress.AutoSize = true;
            lbl_imgAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_imgAddress.Location = new Point(21, 52);
            lbl_imgAddress.Margin = new Padding(6, 0, 6, 0);
            lbl_imgAddress.Name = "lbl_imgAddress";
            lbl_imgAddress.Size = new Size(192, 32);
            lbl_imgAddress.TabIndex = 5;
            lbl_imgAddress.Text = "Đưỡng dẫn ảnh";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(btn_rotateX);
            groupBox3.Controls.Add(btn_rotateY);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(tb_thongSo);
            groupBox3.Controls.Add(lbl_thongSo);
            groupBox3.Controls.Add(contrastTracker);
            groupBox3.Location = new Point(22, 284);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(321, 386);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tuỳ chỉnh";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Chọn loại ghép", "ảnh 1 trái ảnh 2 phải", "ảnh 2 trái ảnh 1 phải", "ảnh 1 trên ảnh 2 dưới", "ảnh 2 trên ảnh 1 dưới" });
            comboBox4.Location = new Point(11, 105);
            comboBox4.Margin = new Padding(6);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(296, 40);
            comboBox4.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 324);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 39);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 207);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 39);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(9, 269);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(167, 49);
            button2.TabIndex = 16;
            button2.Text = "Chọn ảnh 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 154);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(167, 49);
            button1.TabIndex = 15;
            button1.Text = "Chọn ảnh 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_rotateX
            // 
            btn_rotateX.Location = new Point(171, 105);
            btn_rotateX.Margin = new Padding(6);
            btn_rotateX.Name = "btn_rotateX";
            btn_rotateX.Size = new Size(139, 49);
            btn_rotateX.TabIndex = 12;
            btn_rotateX.Text = "Ngang";
            btn_rotateX.UseVisualStyleBackColor = true;
            btn_rotateX.Click += btn_rotateX_Click;
            // 
            // btn_rotateY
            // 
            btn_rotateY.Location = new Point(11, 105);
            btn_rotateY.Margin = new Padding(6);
            btn_rotateY.Name = "btn_rotateY";
            btn_rotateY.Size = new Size(139, 49);
            btn_rotateY.TabIndex = 11;
            btn_rotateY.Text = "Dọc";
            btn_rotateY.UseVisualStyleBackColor = true;
            btn_rotateY.Click += btn_rotateY_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 286);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(228, 32);
            label7.TabIndex = 14;
            label7.Text = "Chọn kích cỡ khung";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 177);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 13;
            label6.Text = "Chọn màu";
            label6.Click += label6_Click;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Chọn kích cỡ khung", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            comboBox3.Location = new Point(11, 324);
            comboBox3.Margin = new Padding(6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(296, 40);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Chọn màu", "black", "white", "red", "green", "blue", "yellow", "cyan", "magenta" });
            comboBox2.Location = new Point(11, 215);
            comboBox2.Margin = new Padding(6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(296, 40);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tb_thongSo
            // 
            tb_thongSo.Location = new Point(11, 107);
            tb_thongSo.Margin = new Padding(6);
            tb_thongSo.Name = "tb_thongSo";
            tb_thongSo.Size = new Size(296, 39);
            tb_thongSo.TabIndex = 10;
            tb_thongSo.TextChanged += tb_thongSo_TextChanged_1;
            // 
            // lbl_thongSo
            // 
            lbl_thongSo.Location = new Point(11, 68);
            lbl_thongSo.Margin = new Padding(6, 0, 6, 0);
            lbl_thongSo.MaximumSize = new Size(371, 213);
            lbl_thongSo.Name = "lbl_thongSo";
            lbl_thongSo.Size = new Size(297, 107);
            lbl_thongSo.TabIndex = 9;
            lbl_thongSo.Text = "Thông số";
            // 
            // contrastTracker
            // 
            contrastTracker.LargeChange = 1;
            contrastTracker.Location = new Point(11, 107);
            contrastTracker.Margin = new Padding(6);
            contrastTracker.Maximum = 20;
            contrastTracker.Name = "contrastTracker";
            contrastTracker.Size = new Size(299, 90);
            contrastTracker.TabIndex = 9;
            contrastTracker.Value = 10;
            contrastTracker.Scroll += contrastTracker_Scroll;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, chỉnhSửaToolStripMenuItem, thaoTácToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1920, 44);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openTSMI, saveTSMI, fomatTSMI });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(74, 36);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // openTSMI
            // 
            openTSMI.Name = "openTSMI";
            openTSMI.Size = new Size(300, 44);
            openTSMI.Text = "Mở";
            openTSMI.Click += openTSMI_Click;
            // 
            // saveTSMI
            // 
            saveTSMI.Name = "saveTSMI";
            saveTSMI.Size = new Size(300, 44);
            saveTSMI.Text = "Lưu";
            saveTSMI.Click += saveTSMI_Click;
            // 
            // fomatTSMI
            // 
            fomatTSMI.Name = "fomatTSMI";
            fomatTSMI.Size = new Size(300, 44);
            fomatTSMI.Text = "Đổi định dạng";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { brightnessTSMI, blurTSMI, colorTSMI, contrastTSMI, removeBkgSTMI, collageTSMI, rotateSTMI, flipTSMI, frameTSMI, cutTSMI, sobelTSMI });
            chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            chỉnhSửaToolStripMenuItem.Size = new Size(140, 36);
            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // brightnessTSMI
            // 
            brightnessTSMI.Name = "brightnessTSMI";
            brightnessTSMI.Size = new Size(377, 44);
            brightnessTSMI.Text = "Chỉnh độ sáng";
            // 
            // blurTSMI
            // 
            blurTSMI.Name = "blurTSMI";
            blurTSMI.Size = new Size(377, 44);
            blurTSMI.Text = "Làm mờ";
            // 
            // colorTSMI
            // 
            colorTSMI.Name = "colorTSMI";
            colorTSMI.Size = new Size(377, 44);
            colorTSMI.Text = "Chỉnh màu";
            // 
            // contrastTSMI
            // 
            contrastTSMI.Name = "contrastTSMI";
            contrastTSMI.Size = new Size(377, 44);
            contrastTSMI.Text = "Chỉnh độ tương phản";
            // 
            // removeBkgSTMI
            // 
            removeBkgSTMI.Name = "removeBkgSTMI";
            removeBkgSTMI.Size = new Size(377, 44);
            removeBkgSTMI.Text = "Xoá phông";
            // 
            // collageTSMI
            // 
            collageTSMI.Name = "collageTSMI";
            collageTSMI.Size = new Size(377, 44);
            collageTSMI.Text = "Ghép ảnh";
            // 
            // rotateSTMI
            // 
            rotateSTMI.Name = "rotateSTMI";
            rotateSTMI.Size = new Size(377, 44);
            rotateSTMI.Text = "Xoay ảnh";
            // 
            // flipTSMI
            // 
            flipTSMI.Name = "flipTSMI";
            flipTSMI.Size = new Size(377, 44);
            flipTSMI.Text = "Lật ảnh";
            // 
            // frameTSMI
            // 
            frameTSMI.Name = "frameTSMI";
            frameTSMI.Size = new Size(377, 44);
            frameTSMI.Text = "Thêm khung ảnh";
            // 
            // cutTSMI
            // 
            cutTSMI.Name = "cutTSMI";
            cutTSMI.Size = new Size(377, 44);
            cutTSMI.Text = "Cắt ảnh";
            // 
            // sobelTSMI
            // 
            sobelTSMI.Name = "sobelTSMI";
            sobelTSMI.Size = new Size(377, 44);
            sobelTSMI.Text = "Lấy biên ảnh";
            sobelTSMI.Click += sobelTSMI_Click;
            // 
            // thaoTácToolStripMenuItem
            // 
            thaoTácToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoTSMI, redoTSMI, presentTSMI });
            thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            thaoTácToolStripMenuItem.Size = new Size(125, 36);
            thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // undoTSMI
            // 
            undoTSMI.Name = "undoTSMI";
            undoTSMI.Size = new Size(360, 44);
            undoTSMI.Text = "Hoàn tác";
            undoTSMI.Click += undoTSMI_Click;
            // 
            // redoTSMI
            // 
            redoTSMI.Name = "redoTSMI";
            redoTSMI.Size = new Size(360, 44);
            redoTSMI.Text = "Làm lại";
            redoTSMI.Click += redoTSMI_Click;
            // 
            // presentTSMI
            // 
            presentTSMI.Name = "presentTSMI";
            presentTSMI.Size = new Size(360, 44);
            presentTSMI.Text = "Ảnh đang chỉnh sửa";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_apDung
            // 
            btn_apDung.Location = new Point(158, 683);
            btn_apDung.Margin = new Padding(6);
            btn_apDung.Name = "btn_apDung";
            btn_apDung.Size = new Size(186, 64);
            btn_apDung.TabIndex = 4;
            btn_apDung.Text = "Áp dụng";
            btn_apDung.UseVisualStyleBackColor = true;
            btn_apDung.Click += btn_apDung_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "---Chọn chức năng---", "Chỉnh độ sáng", "Làm mờ", "Chỉnh màu", "Chỉnh độ tương phản", "Xoá phông", "Ghép ảnh", "Xoay ảnh", "Lật ảnh", "Thêm khung ảnh", "Cắt ảnh", "Lấy biên ảnh" });
            comboBox1.Location = new Point(22, 213);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 40);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 171);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 8;
            label5.Text = "Chức năng";
            // 
            // btn_redo
            // 
            btn_redo.Location = new Point(1696, 617);
            btn_redo.Margin = new Padding(6);
            btn_redo.Name = "btn_redo";
            btn_redo.Size = new Size(93, 53);
            btn_redo.TabIndex = 10;
            btn_redo.Text = ">>";
            btn_redo.UseVisualStyleBackColor = true;
            btn_redo.Click += btn_redo_Click;
            // 
            // btn_undo
            // 
            btn_undo.ImageAlign = ContentAlignment.MiddleRight;
            btn_undo.Location = new Point(1592, 617);
            btn_undo.Margin = new Padding(6);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(93, 53);
            btn_undo.TabIndex = 11;
            btn_undo.Text = "<<";
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Click += btn_undo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1303);
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
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Trình chỉnh sửa ảnh ";
            FormClosed += Form1_FormClosed;
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
        private Label lbl_imgFormat;
        private Label lbl_imgSize;
        private Label lbl_imgAddress;
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
        private Button btn_rotateY;
        private Button btn_redo;
        private Button btn_undo;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem openTSMI;
        private ToolStripMenuItem saveTSMI;
        private ToolStripMenuItem fomatTSMI;
        private TextBox tb_thongSo;

        private Button btn_rotateX;
        private ToolStripMenuItem sobelTSMI;

        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox4;
    }
}
