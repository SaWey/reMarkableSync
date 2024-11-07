﻿
namespace RemarkableSync.OnenoteAddin
{
    partial class RmDownloadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RmDownloadForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rmTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutGraphicWidth = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectPage = new System.Windows.Forms.Label();
            this.lblGraphicWidth = new System.Windows.Forms.Label();
            this.numericGraphicWidth = new System.Windows.Forms.NumericUpDown();
            this.lblGraphicWidthUnit = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cbSelectPage = new System.Windows.Forms.CheckBox();
            this.groupBoxImportOptions = new System.Windows.Forms.GroupBox();
            this.cbShape = new System.Windows.Forms.CheckBox();
            this.cbImage = new System.Windows.Forms.CheckBox();
            this.cbText = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectPages = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutGraphicWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGraphicWidth)).BeginInit();
            this.groupBoxImportOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.btnCancel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblInfo, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.rmTreeView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutGraphicWidth, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.groupBoxImportOptions, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.tableLayoutPanel.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Name = "lblInfo";
            // 
            // rmTreeView
            // 
            this.tableLayoutPanel.SetColumnSpan(this.rmTreeView, 2);
            resources.ApplyResources(this.rmTreeView, "rmTreeView");
            this.rmTreeView.Name = "rmTreeView";
            // 
            // tableLayoutGraphicWidth
            // 
            resources.ApplyResources(this.tableLayoutGraphicWidth, "tableLayoutGraphicWidth");
            this.tableLayoutGraphicWidth.Controls.Add(this.lblSelectPage, 0, 2);
            this.tableLayoutGraphicWidth.Controls.Add(this.lblGraphicWidth, 0, 0);
            this.tableLayoutGraphicWidth.Controls.Add(this.numericGraphicWidth, 1, 0);
            this.tableLayoutGraphicWidth.Controls.Add(this.lblGraphicWidthUnit, 2, 0);
            this.tableLayoutGraphicWidth.Controls.Add(this.labelLanguage, 0, 1);
            this.tableLayoutGraphicWidth.Controls.Add(this.cboLanguage, 1, 1);
            this.tableLayoutGraphicWidth.Controls.Add(this.cbSelectPage, 1, 2);
            this.tableLayoutGraphicWidth.Name = "tableLayoutGraphicWidth";
            // 
            // lblSelectPage
            // 
            resources.ApplyResources(this.lblSelectPage, "lblSelectPage");
            this.lblSelectPage.Name = "lblSelectPage";
            // 
            // lblGraphicWidth
            // 
            resources.ApplyResources(this.lblGraphicWidth, "lblGraphicWidth");
            this.lblGraphicWidth.Name = "lblGraphicWidth";
            // 
            // numericGraphicWidth
            // 
            resources.ApplyResources(this.numericGraphicWidth, "numericGraphicWidth");
            this.numericGraphicWidth.Name = "numericGraphicWidth";
            this.numericGraphicWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblGraphicWidthUnit
            // 
            resources.ApplyResources(this.lblGraphicWidthUnit, "lblGraphicWidthUnit");
            this.lblGraphicWidthUnit.Name = "lblGraphicWidthUnit";
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // cboLanguage
            // 
            this.tableLayoutGraphicWidth.SetColumnSpan(this.cboLanguage, 2);
            this.cboLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.cboLanguage, "cboLanguage");
            this.cboLanguage.Name = "cboLanguage";
            // 
            // cbSelectPage
            // 
            resources.ApplyResources(this.cbSelectPage, "cbSelectPage");
            this.cbSelectPage.Name = "cbSelectPage";
            this.cbSelectPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxImportOptions
            // 
            this.groupBoxImportOptions.Controls.Add(this.cbShape);
            this.groupBoxImportOptions.Controls.Add(this.cbImage);
            this.groupBoxImportOptions.Controls.Add(this.cbText);
            resources.ApplyResources(this.groupBoxImportOptions, "groupBoxImportOptions");
            this.groupBoxImportOptions.Name = "groupBoxImportOptions";
            this.groupBoxImportOptions.TabStop = false;
            // 
            // cbShape
            // 
            resources.ApplyResources(this.cbShape, "cbShape");
            this.cbShape.Checked = true;
            this.cbShape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShape.Name = "cbShape";
            this.cbShape.UseVisualStyleBackColor = true;
            // 
            // cbImage
            // 
            resources.ApplyResources(this.cbImage, "cbImage");
            this.cbImage.Name = "cbImage";
            this.cbImage.UseVisualStyleBackColor = true;
            // 
            // cbText
            // 
            resources.ApplyResources(this.cbText, "cbText");
            this.cbText.Name = "cbText";
            this.cbText.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectPages);
            this.panel1.Controls.Add(this.btnOk);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnSelectPages
            // 
            resources.ApplyResources(this.btnSelectPages, "btnSelectPages");
            this.btnSelectPages.Name = "btnSelectPages";
            this.btnSelectPages.UseVisualStyleBackColor = true;
            this.btnSelectPages.Click += new System.EventHandler(this.btnSelectPages_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // RmDownloadForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RmDownloadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RmDownloadForm_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutGraphicWidth.ResumeLayout(false);
            this.tableLayoutGraphicWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGraphicWidth)).EndInit();
            this.groupBoxImportOptions.ResumeLayout(false);
            this.groupBoxImportOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TreeView rmTreeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGraphicWidth;
        private System.Windows.Forms.Label lblGraphicWidth;
        private System.Windows.Forms.NumericUpDown numericGraphicWidth;
        private System.Windows.Forms.Label lblGraphicWidthUnit;
        private System.Windows.Forms.GroupBox groupBoxImportOptions;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblSelectPage;
        private System.Windows.Forms.CheckBox cbSelectPage;
        private System.Windows.Forms.CheckBox cbShape;
        private System.Windows.Forms.CheckBox cbImage;
        private System.Windows.Forms.CheckBox cbText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectPages;
        private System.Windows.Forms.Button btnOk;
    }
}