﻿namespace WEF.ModelGenerator.Forms
{
    partial class JsonClassGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonClassGeneratorForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            //this.edtJson = new System.Windows.Forms.TextBox();
            this.edtJson = new Controls.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radFields = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radPublic = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radProperties = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radInternal = new System.Windows.Forms.RadioButton();
            this.edtSecondaryNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radSameNamespace = new System.Windows.Forms.RadioButton();
            this.radDifferentNamespace = new System.Windows.Forms.RadioButton();
            this.radNestedClasses = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSingleFile = new System.Windows.Forms.CheckBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.lnkOpenFolder = new System.Windows.Forms.LinkLabel();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblDoneClipboard = new System.Windows.Forms.Label();
            this.chkDocumentationExamples = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExplicitDeserialization = new System.Windows.Forms.CheckBox();
            this.chkNoHelper = new System.Windows.Forms.CheckBox();
            this.chkPascalCase = new System.Windows.Forms.CheckBox();
            this.chkApplyObfuscationAttributes = new System.Windows.Forms.CheckBox();
            this.edtMainClass = new System.Windows.Forms.TextBox();
            this.edtNamespace = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(1038, 523);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 35);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "生成文件(F6)";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // edtJson
            // 
            this.edtJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.edtJson.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtJson.Location = new System.Drawing.Point(328, 78);
            this.edtJson.MaximumSize = new System.Drawing.Size(100000, 100000);
            this.edtJson.MaxLength = 10000000;
            this.edtJson.Multiline = true;
            this.edtJson.Name = "edtJson";
            this.edtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtJson.Size = new System.Drawing.Size(799, 230);
            this.edtJson.TabIndex = 14;
            this.edtJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtJson_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(306, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "请在下面输入Json";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(12, 41);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(53, 12);
            this.lblNamespace.TabIndex = 4;
            this.lblNamespace.Text = "命名空间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "成员类型";
            // 
            // radFields
            // 
            this.radFields.AutoSize = true;
            this.radFields.Location = new System.Drawing.Point(56, 3);
            this.radFields.Name = "radFields";
            this.radFields.Size = new System.Drawing.Size(47, 16);
            this.radFields.TabIndex = 1;
            this.radFields.Text = "字段";
            this.radFields.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "可见范围";
            // 
            // radPublic
            // 
            this.radPublic.AutoSize = true;
            this.radPublic.Location = new System.Drawing.Point(80, 3);
            this.radPublic.Name = "radPublic";
            this.radPublic.Size = new System.Drawing.Size(59, 16);
            this.radPublic.TabIndex = 1;
            this.radPublic.Text = "Public";
            this.radPublic.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.radProperties);
            this.flowLayoutPanel1.Controls.Add(this.radFields);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(102, 260);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 22);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // radProperties
            // 
            this.radProperties.AutoSize = true;
            this.radProperties.Checked = true;
            this.radProperties.Location = new System.Drawing.Point(3, 3);
            this.radProperties.Name = "radProperties";
            this.radProperties.Size = new System.Drawing.Size(47, 16);
            this.radProperties.TabIndex = 0;
            this.radProperties.TabStop = true;
            this.radProperties.Text = "属性";
            this.radProperties.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.radInternal);
            this.flowLayoutPanel2.Controls.Add(this.radPublic);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(102, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 22);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // radInternal
            // 
            this.radInternal.AutoSize = true;
            this.radInternal.Checked = true;
            this.radInternal.Location = new System.Drawing.Point(3, 3);
            this.radInternal.Name = "radInternal";
            this.radInternal.Size = new System.Drawing.Size(71, 16);
            this.radInternal.TabIndex = 0;
            this.radInternal.TabStop = true;
            this.radInternal.Text = "Internal";
            this.radInternal.UseVisualStyleBackColor = true;
            // 
            // edtSecondaryNamespace
            // 
            this.edtSecondaryNamespace.Location = new System.Drawing.Point(22, 69);
            this.edtSecondaryNamespace.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.edtSecondaryNamespace.Multiline = true;
            this.edtSecondaryNamespace.Name = "edtSecondaryNamespace";
            this.edtSecondaryNamespace.Size = new System.Drawing.Size(161, 56);
            this.edtSecondaryNamespace.TabIndex = 3;
            this.edtSecondaryNamespace.Text = "Example.JsonTypes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "主类名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "实体类选择项";
            // 
            // radSameNamespace
            // 
            this.radSameNamespace.AutoSize = true;
            this.radSameNamespace.Location = new System.Drawing.Point(3, 25);
            this.radSameNamespace.Name = "radSameNamespace";
            this.radSameNamespace.Size = new System.Drawing.Size(131, 16);
            this.radSameNamespace.TabIndex = 1;
            this.radSameNamespace.TabStop = true;
            this.radSameNamespace.Text = "使用相同的命名空间";
            this.radSameNamespace.UseVisualStyleBackColor = true;
            this.radSameNamespace.CheckedChanged += new System.EventHandler(this.radSameNamespace_CheckedChanged);
            // 
            // radDifferentNamespace
            // 
            this.radDifferentNamespace.AutoSize = true;
            this.radDifferentNamespace.Location = new System.Drawing.Point(3, 47);
            this.radDifferentNamespace.Name = "radDifferentNamespace";
            this.radDifferentNamespace.Size = new System.Drawing.Size(131, 16);
            this.radDifferentNamespace.TabIndex = 2;
            this.radDifferentNamespace.TabStop = true;
            this.radDifferentNamespace.Text = "使用不同的命名空间";
            this.radDifferentNamespace.UseVisualStyleBackColor = true;
            this.radDifferentNamespace.CheckedChanged += new System.EventHandler(this.radDifferentNamespace_CheckedChanged);
            // 
            // radNestedClasses
            // 
            this.radNestedClasses.AutoSize = true;
            this.radNestedClasses.Location = new System.Drawing.Point(3, 3);
            this.radNestedClasses.Name = "radNestedClasses";
            this.radNestedClasses.Size = new System.Drawing.Size(83, 16);
            this.radNestedClasses.TabIndex = 0;
            this.radNestedClasses.TabStop = true;
            this.radNestedClasses.Text = "使用嵌套类";
            this.radNestedClasses.UseVisualStyleBackColor = true;
            this.radNestedClasses.CheckedChanged += new System.EventHandler(this.radNestedClasses_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radNestedClasses);
            this.flowLayoutPanel3.Controls.Add(this.radSameNamespace);
            this.flowLayoutPanel3.Controls.Add(this.radDifferentNamespace);
            this.flowLayoutPanel3.Controls.Add(this.edtSecondaryNamespace);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(102, 110);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(185, 138);
            this.flowLayoutPanel3.TabIndex = 5;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // chkSingleFile
            // 
            this.chkSingleFile.AutoSize = true;
            this.chkSingleFile.Location = new System.Drawing.Point(89, 109);
            this.chkSingleFile.Name = "chkSingleFile";
            this.chkSingleFile.Size = new System.Drawing.Size(108, 16);
            this.chkSingleFile.TabIndex = 13;
            this.chkSingleFile.Text = "生成的单个文件";
            this.chkSingleFile.UseVisualStyleBackColor = true;
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.Color.Red;
            this.lblDone.Location = new System.Drawing.Point(823, 528);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(111, 13);
            this.lblDone.TabIndex = 38;
            this.lblDone.Text = "实体文件已生成！";
            this.lblDone.Visible = false;
            // 
            // lnkOpenFolder
            // 
            this.lnkOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOpenFolder.AutoSize = true;
            this.lnkOpenFolder.Location = new System.Drawing.Point(821, 544);
            this.lnkOpenFolder.Name = "lnkOpenFolder";
            this.lnkOpenFolder.Size = new System.Drawing.Size(113, 12);
            this.lnkOpenFolder.TabIndex = 39;
            this.lnkOpenFolder.TabStop = true;
            this.lnkOpenFolder.Text = "打开生成的文件目录";
            this.lnkOpenFolder.Visible = false;
            this.lnkOpenFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenFolder_LinkClicked);
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 7000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(940, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "校验Json(F5)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPasteAndGo_Click);
            // 
            // lblDoneClipboard
            // 
            this.lblDoneClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoneClipboard.AutoSize = true;
            this.lblDoneClipboard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneClipboard.ForeColor = System.Drawing.Color.Green;
            this.lblDoneClipboard.Location = new System.Drawing.Point(875, 528);
            this.lblDoneClipboard.Name = "lblDoneClipboard";
            this.lblDoneClipboard.Size = new System.Drawing.Size(59, 13);
            this.lblDoneClipboard.TabIndex = 38;
            this.lblDoneClipboard.Text = "校验完成";
            this.lblDoneClipboard.Visible = false;
            // 
            // chkDocumentationExamples
            // 
            this.chkDocumentationExamples.AutoSize = true;
            this.chkDocumentationExamples.Location = new System.Drawing.Point(89, 130);
            this.chkDocumentationExamples.Name = "chkDocumentationExamples";
            this.chkDocumentationExamples.Size = new System.Drawing.Size(144, 16);
            this.chkDocumentationExamples.TabIndex = 40;
            this.chkDocumentationExamples.Text = "产生的数据的实例文档";
            this.chkDocumentationExamples.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExplicitDeserialization);
            this.groupBox1.Controls.Add(this.chkNoHelper);
            this.groupBox1.Controls.Add(this.chkDocumentationExamples);
            this.groupBox1.Controls.Add(this.chkPascalCase);
            this.groupBox1.Controls.Add(this.chkApplyObfuscationAttributes);
            this.groupBox1.Controls.Add(this.chkSingleFile);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 160);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更多选项";
            // 
            // chkExplicitDeserialization
            // 
            this.chkExplicitDeserialization.AutoSize = true;
            this.chkExplicitDeserialization.Checked = global::WEF.ModelGenerator.Properties.Settings.Default.UseExplicitDeserialization;
            this.chkExplicitDeserialization.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WEF.ModelGenerator.Properties.Settings.Default, "UseExplicitDeserialization", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkExplicitDeserialization.Location = new System.Drawing.Point(89, 44);
            this.chkExplicitDeserialization.Name = "chkExplicitDeserialization";
            this.chkExplicitDeserialization.Size = new System.Drawing.Size(132, 16);
            this.chkExplicitDeserialization.TabIndex = 10;
            this.chkExplicitDeserialization.Text = "使用显式的反序列化";
            this.chkExplicitDeserialization.UseVisualStyleBackColor = true;
            this.chkExplicitDeserialization.CheckedChanged += new System.EventHandler(this.chkExplicitDeserialization_CheckedChanged);
            // 
            // chkNoHelper
            // 
            this.chkNoHelper.AutoSize = true;
            this.chkNoHelper.Checked = global::WEF.ModelGenerator.Properties.Settings.Default.NoHelper;
            this.chkNoHelper.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WEF.ModelGenerator.Properties.Settings.Default, "NoHelper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNoHelper.Location = new System.Drawing.Point(106, 65);
            this.chkNoHelper.Name = "chkNoHelper";
            this.chkNoHelper.Size = new System.Drawing.Size(96, 16);
            this.chkNoHelper.TabIndex = 11;
            this.chkNoHelper.Text = "不产生辅助类";
            this.chkNoHelper.UseVisualStyleBackColor = true;
            // 
            // chkPascalCase
            // 
            this.chkPascalCase.AutoSize = true;
            this.chkPascalCase.Checked = global::WEF.ModelGenerator.Properties.Settings.Default.UsePascalCase;
            this.chkPascalCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPascalCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WEF.ModelGenerator.Properties.Settings.Default, "UsePascalCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkPascalCase.Location = new System.Drawing.Point(89, 23);
            this.chkPascalCase.Name = "chkPascalCase";
            this.chkPascalCase.Size = new System.Drawing.Size(84, 16);
            this.chkPascalCase.TabIndex = 9;
            this.chkPascalCase.Text = "属性名大写";
            this.chkPascalCase.UseVisualStyleBackColor = true;
            // 
            // chkApplyObfuscationAttributes
            // 
            this.chkApplyObfuscationAttributes.AutoSize = true;
            this.chkApplyObfuscationAttributes.Checked = global::WEF.ModelGenerator.Properties.Settings.Default.ApplyObfuscationAttributes;
            this.chkApplyObfuscationAttributes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WEF.ModelGenerator.Properties.Settings.Default, "ApplyObfuscationAttributes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkApplyObfuscationAttributes.Location = new System.Drawing.Point(89, 87);
            this.chkApplyObfuscationAttributes.Name = "chkApplyObfuscationAttributes";
            this.chkApplyObfuscationAttributes.Size = new System.Drawing.Size(120, 16);
            this.chkApplyObfuscationAttributes.TabIndex = 12;
            this.chkApplyObfuscationAttributes.Text = "应用混淆排除属性";
            this.chkApplyObfuscationAttributes.UseVisualStyleBackColor = true;
            // 
            // edtMainClass
            // 
            this.edtMainClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WEF.ModelGenerator.Properties.Settings.Default, "MainClassName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.edtMainClass.Location = new System.Drawing.Point(101, 64);
            this.edtMainClass.Name = "edtMainClass";
            this.edtMainClass.Size = new System.Drawing.Size(185, 21);
            this.edtMainClass.TabIndex = 1;
            this.edtMainClass.Text = global::WEF.ModelGenerator.Properties.Settings.Default.MainClassName;
            this.edtMainClass.TextChanged += new System.EventHandler(this.edtMainClass_TextChanged);
            // 
            // edtNamespace
            // 
            this.edtNamespace.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WEF.ModelGenerator.Properties.Settings.Default, "Namespace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.edtNamespace.Location = new System.Drawing.Point(101, 38);
            this.edtNamespace.Name = "edtNamespace";
            this.edtNamespace.Size = new System.Drawing.Size(185, 21);
            this.edtNamespace.TabIndex = 0;
            this.edtNamespace.Text = global::WEF.ModelGenerator.Properties.Settings.Default.Namespace;
            this.edtNamespace.TextChanged += new System.EventHandler(this.edtNamespace_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::WEF.ModelGenerator.Properties.Resources.VR;
            this.pictureBox5.Location = new System.Drawing.Point(321, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(806, 12);
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::WEF.ModelGenerator.Properties.Resources.HR;
            this.pictureBox4.Location = new System.Drawing.Point(312, 69);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(10, 1000000);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 438);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(15, 98);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(10000000, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(271, 1);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(13, 513);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(10000000, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1114, 1);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(299, 37);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1, 100000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 477);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(972, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 12);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Power by yswenli @2015-1-29";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox6.Location = new System.Drawing.Point(14, 246);
            this.pictureBox6.MaximumSize = new System.Drawing.Size(10000000, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(271, 1);
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox7.Location = new System.Drawing.Point(14, 328);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(10000000, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(271, 1);
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // codeTxt
            // 
            this.codeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTxt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.Location = new System.Drawing.Point(328, 315);
            this.codeTxt.Multiline = true;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.ReadOnly = true;
            this.codeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTxt.Size = new System.Drawing.Size(799, 192);
            this.codeTxt.TabIndex = 51;
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(328, 524);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(89, 32);
            this.skinButton1.TabIndex = 52;
            this.skinButton1.Text = "展开";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(423, 524);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(89, 32);
            this.skinButton2.TabIndex = 52;
            this.skinButton2.Text = "收缩";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(518, 524);
            this.skinButton3.MouseBack = null;
            this.skinButton3.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(89, 32);
            this.skinButton3.TabIndex = 52;
            this.skinButton3.Text = "转义";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton4
            // 
            this.skinButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(613, 524);
            this.skinButton4.MouseBack = null;
            this.skinButton4.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(89, 32);
            this.skinButton4.TabIndex = 52;
            this.skinButton4.Text = "去转义";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // JsonClassGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 565);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkOpenFolder);
            this.Controls.Add(this.lblDoneClipboard);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtMainClass);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.edtNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtJson);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(100000, 100000);
            this.MinimumSize = new System.Drawing.Size(1155, 565);
            this.Name = "JsonClassGeneratorForm";
            this.Text = "Json实体类生成工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCSharpClassGeneration_FormClosing);
            this.Load += new System.EventHandler(this.frmCSharpClassGeneration_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private WEF.ModelGenerator.Controls.MyTextBox edtJson;
        //private System.Windows.Forms.TextBox edtJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNamespace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.CheckBox chkNoHelper;
        private System.Windows.Forms.TextBox edtSecondaryNamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radFields;
        private System.Windows.Forms.RadioButton radProperties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radInternal;
        private System.Windows.Forms.RadioButton radPublic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox edtMainClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPascalCase;
        private System.Windows.Forms.CheckBox chkExplicitDeserialization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radSameNamespace;
        private System.Windows.Forms.RadioButton radDifferentNamespace;
        private System.Windows.Forms.RadioButton radNestedClasses;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkApplyObfuscationAttributes;
        private System.Windows.Forms.CheckBox chkSingleFile;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.LinkLabel lnkOpenFolder;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDoneClipboard;
        private System.Windows.Forms.CheckBox chkDocumentationExamples;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox codeTxt;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton4;
    }
}

