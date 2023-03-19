using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using VISTA.Notifications;

namespace VISTA.Backup
{
    public partial class frmBackup : Form
    {
        #region constructor
        public frmBackup()
        {
            InitializeComponent();
        }
        #endregion

        #region topBar
        int posY = 0;
        int posX = 0;
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            //Esto sirve para que se pueda mover el formulario desde el panel superior
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                BackupDatabase(txtBackupName.Text);
            }
            catch (Exception )
            {
                DialogResult resultado = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                resultado = formErrorUnexpected.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    return;
                }
                throw;
            }

        }
        public void BackupDatabase(string databaseName, string localDatabasePath = null)
        {
            if(databaseName == "")
            {
                DialogResult resultado = new DialogResult();
                frmErrorBackupName formErrorBackupName = new frmErrorBackupName();
                resultado = formErrorBackupName.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    return;
                }
            }
            // use the default sql server base path from appsettings.json if localDatabasePath is null
            if (localDatabasePath == null)
            {
                localDatabasePath = Path.Combine("C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL", "Backup", $"{databaseName}.bak");
            }
            // otherwise check if it ends with .bak
            else if (!localDatabasePath.EndsWith(".bak"))
            {
                throw new ArgumentException("localDatabasePath must end with .bak.");
            }

            var formatMediaName = $"DatabaseToolkitBackup_{databaseName}";
            var formatName = $"Full Backup of {databaseName}";

            var connectionString = "data source=localhost\\SQLEXPRESS;initial catalog=CONTEXTO.TeraflopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"BACKUP DATABASE @databaseName
                    TO DISK = @localDatabasePath
                    WITH FORMAT,
                      MEDIANAME = @formatMediaName,
                        NAME = @formatName";

                connection.Open();

                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 7200;
                    command.Parameters.AddWithValue("@databaseName", "CONTEXTO.TeraflopSystem");
                    command.Parameters.AddWithValue("@localDatabasePath", localDatabasePath);
                    command.Parameters.AddWithValue("@formatMediaName", formatMediaName);
                    command.Parameters.AddWithValue("@formatName", formatName);

                    command.ExecuteNonQuery();
                }
            }
            frmSuccessfullyBackup formSuccessfullyBackup = new frmSuccessfullyBackup();
            formSuccessfullyBackup.ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "data source=localhost\\SQLEXPRESS;initial catalog=CONTEXTO.TeraflopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                string database = "CONTEXTO.TeraflopSystem";

                var connection = new SqlConnection(connectionString);
                connection.Open();

                if (txtPathRestore.Text == "")
                {
                    DialogResult resultado = new DialogResult();
                    frmErrorRestoreName formErrorRestoreName = new frmErrorRestoreName();
                    resultado = formErrorRestoreName.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        return;
                    }
                }
                // "USE MASTER RESTORE DATABASE [CONTEXTO.TeraflopSystem] FROM DISK=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\TeraflopSystem19-03-23.bak WITH REPLACE;"
                bool isBackup = txtPathRestore.Text.Contains(".bak");

                var sql1 = "ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                var command1 = new SqlCommand(sql1, connection);
                command1.ExecuteNonQuery();

                var sql2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\" + txtPathRestore.Text +"' WITH REPLACE;";
                var command2 = new SqlCommand(sql2, connection);
                command2.ExecuteNonQuery();
                var sql3 = "ALTER DATABASE [" + database + "] SET MULTI_USER";
                var command3 = new SqlCommand(sql3, connection);
                command3.ExecuteNonQuery();

                frmSuccessfullyRestoreBackup formSuccessfullyRestoreBackup = new frmSuccessfullyRestoreBackup();
                formSuccessfullyRestoreBackup.ShowDialog();
                connection.Close();
            }
            catch (Exception)
            {
                DialogResult resultado = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                resultado = formErrorUnexpected.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void btnRouteRestore_Click(object sender, EventArgs e)
        {
            string routeSave = "";
            string[] arrayRoute;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                routeSave = openFileDialog.FileName;
            }
            arrayRoute = routeSave.Split('\\');
            txtPathRestore.Text = arrayRoute[arrayRoute.Length - 1].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
