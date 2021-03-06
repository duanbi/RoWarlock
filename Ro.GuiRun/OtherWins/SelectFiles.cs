﻿using System;
using System.IO;
using System.Windows.Forms;
using DMSkin;
using Ro.Common.Args;
using Ro.Common.UserType.GuiType;

namespace Ro.GuiRun.OtherWins
{
    public partial class SelectFiles : DMSkinForm
    {
        public SelectFiles()
        {
            InitializeComponent();
           
        }


        /// <summary>
        /// 选择脚本文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rosB_Click(object sender, EventArgs e)
        {
            //弹出文件夹选择框
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = @"选取Ros文件夹",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog() == DialogResult.OK || fbd.ShowDialog() == DialogResult.Yes)
            {
                ComArgs.GuiUsePath.RosPath = fbd.SelectedPath;
                rosT.Text = ComArgs.GuiUsePath.RosPath;
            }
            else
            {
                MessageBox.Show(@"没有选择测试脚本文件", @"警告");
            }
        }


        /// <summary>
        /// 选择元素集文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roiB_Click(object sender, EventArgs e)
        {
            //弹出文件夹选择框
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = @"选取Roi文件夹",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog() == DialogResult.OK || fbd.ShowDialog() == DialogResult.Yes)
            {
                ComArgs.GuiUsePath.RoiPath = fbd.SelectedPath;
                roiT.Text = ComArgs.GuiUsePath.RoiPath;
            }
            else
            {
                MessageBox.Show(@"没有选择测试脚本文件", @"警告");
            }
        }


        /// <summary>
        /// 选择配置文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rocB_Click(object sender, EventArgs e)
        {
            //弹出文件夹选择框
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = @"选取Roc文件夹",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog() == DialogResult.OK || fbd.ShowDialog() == DialogResult.Yes)
            {
                ComArgs.GuiUsePath.RocPath = fbd.SelectedPath;
                rocT.Text = ComArgs.GuiUsePath.RocPath;
            }
            else
            {
                MessageBox.Show(@"没有选择测试脚本文件", @"警告");
            }
        }


        /// <summary>
        /// 选择并保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            if (ComArgs.GuiUsePath == null || ComArgs.GuiUsePath.RosPath == null || ComArgs.GuiUsePath.RocPath == null || ComArgs.GuiUsePath.RoiPath == null)
            {
                MessageBox.Show(@"没有选择测试脚本文件,请重新选择", @"警告");
            }
            else
            {
                MessageBox.Show(
                    $@"Ros路径:{new DirectoryInfo(ComArgs.GuiUsePath.RosPath).Name}" 
                    +"\r\n"+ $@"Roi路径:{new DirectoryInfo(ComArgs.GuiUsePath.RoiPath).Name}"
                    + "\r\n" + $@"Roc路径:{new DirectoryInfo(ComArgs.GuiUsePath.RocPath).Name}", @"信息");
                Close();
            }
        }
    }
}
