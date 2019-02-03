using System;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ITVDN_HW_AppDomain_and_Services
{
    public partial class Form1 : Form
    {
        private SecurityPermission _secPerm = new SecurityPermission(PermissionState.None);
        private FileIOPermission _filePerm = new FileIOPermission(PermissionState.None);
        private ReflectionPermission _reflPerm = new ReflectionPermission(PermissionState.None);

        private string _filepath = String.Empty;
        private AppDomain domain = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBArg.Items.Clear();
            switch (LBOption.SelectedIndex)
            {
                case 0:
                {
                    LBArg.Items.Add((SecurityPermissionFlag)0);
                    for (int i = 1; i < 8193; i*=2)
                        LBArg.Items.Add((SecurityPermissionFlag)i);
                        break;
                }
                case 1:
                {
                    LBArg.Items.Add(FileIOPermissionAccess.AllAccess);
                    LBArg.Items.Add((FileIOPermissionAccess)0);
                    for (int i = 1; i < 9; i *= 2)
                        LBArg.Items.Add((FileIOPermissionAccess)i);
                        break;
                }
                case 2:
                {
                    LBArg.Items.Add(ReflectionPermissionFlag.NoFlags);
                    LBArg.Items.Add(ReflectionPermissionFlag.MemberAccess);
                        break;
                }
            }
        }

        private void LBArg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtSetOpt.Enabled = true;

        }

        private void BtSetOpt_Click(object sender, EventArgs e)
        {
            switch (LBOption.SelectedIndex)
            {
                case 0:
                {
                    SecurityPermissionFlag flag = 0;
                    if (LBArg.SelectedIndex == 0 || LBArg.SelectedIndex == 1)
                        flag = (SecurityPermissionFlag)LBArg.SelectedIndex;
                    else
                        flag = (SecurityPermissionFlag)Math.Pow(2, LBArg.SelectedIndex - 1);

                    if (MessageBox.Show($"Sure to add parametr: {flag}", "Question", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _secPerm.Flags = flag;
                        LBAddFlg.Items.Add((nameof(SecurityPermission) + ": " + flag + "."));
                    }
                    break;
                }
                case 1:
                {
                    FileIOPermissionAccess flag = 0;
                    if (LBArg.SelectedIndex == 0)
                        flag = FileIOPermissionAccess.AllAccess;
                    else if (LBArg.SelectedIndex == 1 || LBArg.SelectedIndex == 2)
                        flag = (FileIOPermissionAccess)LBArg.SelectedIndex-1;
                    else
                        flag = (FileIOPermissionAccess)Math.Pow(2, LBArg.SelectedIndex - 2);

                    if (MessageBox.Show($"Sure to add parametr: {flag}", "Question", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _filePerm.AllLocalFiles = flag;
                        LBAddFlg.Items.Add((nameof(FileIOPermission) + ": " + flag + "."));
                    }
                    break;
                }
                case 2:
                {
                    ReflectionPermissionFlag flag = 0;
                    if (LBArg.SelectedIndex == 0)
                        flag = ReflectionPermissionFlag.NoFlags;
                    else
                        flag = ReflectionPermissionFlag.MemberAccess;

                    if (MessageBox.Show($"Sure to add parametr: {flag}", "Question", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _reflPerm.Flags = flag;
                        LBAddFlg.Items.Add((nameof(ReflectionPermission) + ": " + flag + "."));
                    }
                        break;
                }            
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = "exe or dll files | *.exe; *.dll";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _filepath = dlg.FileName;
                RTBFilePath.Text = _filepath;
                TBRefInfo.Text = SafeExecuter.GetTypeOfDll(_filepath);
                BtRun.Enabled = true;
            }
        }

        private void BtRun_Click(object sender, EventArgs e)
        {
            //SafeExecuter.AddPermission(_filePerm);
            //SafeExecuter.AddPermission(_reflPerm);
            //SafeExecuter.AddPermission(_secPerm);

            

            PermissionSet set = new PermissionSet(PermissionState.None);
            set.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            //set.AddPermission(_reflPerm);
            //set.AddPermission(_secPerm);

            try
            {
                domain = SafeExecuter.SafeRunExe(_filepath, Path.GetFileName(_filepath));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }
    }
}

//SecurityPermission
//FileIOPermission
//ReflectionPermission

