﻿namespace AptechWinforms.Assignments
{
    partial class AssignmentForm03
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Core Java");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sql Server");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Year 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("JSP");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Spring MVC");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Year 2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Java Full Stack", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Year 1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Year 2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode(".NET Full Stack", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Database", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Programming", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentForm03));
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewCourse = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewSyllabus = new System.Windows.Forms.ListView();
            this.listViewCourse = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harold College";
            // 
            // treeViewCourse
            // 
            this.treeViewCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCourse.Location = new System.Drawing.Point(0, 0);
            this.treeViewCourse.Name = "treeViewCourse";
            treeNode1.Name = "JavaBasic";
            treeNode1.Text = "Core Java";
            treeNode2.Name = "SQL";
            treeNode2.Text = "Sql Server";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Year 1";
            treeNode4.Name = "JSP";
            treeNode4.Text = "JSP";
            treeNode5.Name = "SpringMVC";
            treeNode5.Text = "Spring MVC";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Year 2";
            treeNode7.Name = "Course-Java";
            treeNode7.Text = "Java Full Stack";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Year 1";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Year 2";
            treeNode10.Name = "Course-NET";
            treeNode10.Text = ".NET Full Stack";
            this.treeViewCourse.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode10});
            this.treeViewCourse.Size = new System.Drawing.Size(266, 647);
            this.treeViewCourse.TabIndex = 3;
            this.treeViewCourse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCourse_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewCourse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewSyllabus);
            this.splitContainer1.Panel2.Controls.Add(this.listViewCourse);
            this.splitContainer1.Size = new System.Drawing.Size(800, 647);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 4;
            // 
            // listViewSyllabus
            // 
            this.listViewSyllabus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewSyllabus.HideSelection = false;
            this.listViewSyllabus.Location = new System.Drawing.Point(0, 325);
            this.listViewSyllabus.Name = "listViewSyllabus";
            this.listViewSyllabus.Size = new System.Drawing.Size(530, 322);
            this.listViewSyllabus.TabIndex = 1;
            this.listViewSyllabus.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCourse
            // 
            this.listViewCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCourse.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup1.Header = "Database";
            listViewGroup1.Name = "listViewGroupDatabase";
            listViewGroup2.Header = "Programming";
            listViewGroup2.Name = "listViewGroupProgramming";
            this.listViewCourse.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listViewCourse.HideSelection = false;
            this.listViewCourse.LargeImageList = this.imageList2;
            this.listViewCourse.Location = new System.Drawing.Point(0, 0);
            this.listViewCourse.Name = "listViewCourse";
            this.listViewCourse.Size = new System.Drawing.Size(530, 319);
            this.listViewCourse.SmallImageList = this.imageList1;
            this.listViewCourse.TabIndex = 0;
            this.listViewCourse.UseCompatibleStateImageBehavior = false;
            this.listViewCourse.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End date";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration (Weeks)";
            this.columnHeader4.Width = 100;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "text_x_csharp.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "text_x_csharp.png");
            // 
            // AssignmentForm03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssignmentForm03";
            this.Text = "AssigmentForm03";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewCourse;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewCourse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewSyllabus;
    }
}