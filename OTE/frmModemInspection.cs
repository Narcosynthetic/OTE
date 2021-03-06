﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTE
{
    public partial class frmModemInspection : Form
    {
        #region Properties
        private Enums.SavingMode Mode
        {
            get;
            set;
        }

        private int ModemId
        {
            get;
            set;
        }

        #endregion

        #region Constructors
        public frmModemInspection()
        {
            InitializeComponent();
        }
        
        #endregion

        #region Events
        private void ModemInspection_Load(object sender, EventArgs e)
        {
            ColorConverter cc = new ColorConverter();
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).BackColoring))
                this.BackColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).BackColoring);
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).ForeColoring))
                this.ForeColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).ForeColoring);

            LoadSaps();
            LoadDailyModems();
            this.Mode = Enums.SavingMode.Insert;
            HandleFormControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
                if (this.Mode == Enums.SavingMode.Insert)
                    InsertTechModem();
                else
                    UpdateTechModem();


            this.Mode = Enums.SavingMode.Insert;
            HandleFormControls();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getModemsBindingSource.DataSource = GetModemsFromDB(dtpDateFrom.Checked ? dtpDateFrom.Value.Date : Helpers.GetDefaultDate(), dtpDateFrom.Checked ? dtpDateTo.Value.Date : Helpers.GetDefaultDate());
        }

        private void dgvModemsPersonal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = int.Parse(dgvModemsPersonal.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                this.ModemId = id;
                LoadModem(this.ModemId);
                this.Mode = Enums.SavingMode.Update;
                HandleFormControls();
            }
        }

        #endregion

        #region Methods
        private void LoadSaps()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetSaps]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            
                            if (dt.Rows.Count > 0)
                            {
                                cbxSap.DataSource = dt;
                                cbxSap.DisplayMember = "Sap";
                                cbxSap.ValueMember = "Id";
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void InsertTechModem()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertTechModem]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SerialNumber", txtSn.Text.Trim());
                        cmd.Parameters.AddWithValue("@Sap", int.Parse(cbxSap.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@UserId", ((frmMain)this.MdiParent).UserId);
                        cmd.Parameters.AddWithValue("@HmeromhniaElenxou", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Power", chbPower.Checked);
                        cmd.Parameters.AddWithValue("@Dsl", chbDsl.Checked);
                        cmd.Parameters.AddWithValue("@Internet", chbInternet.Checked);
                        cmd.Parameters.AddWithValue("@Wlan", chbWlan.Checked);
                        cmd.Parameters.AddWithValue("@Wps", chbWps.Checked);
                        cmd.Parameters.AddWithValue("@Lan1", chbLan1.Checked);
                        cmd.Parameters.AddWithValue("@Lan2", chbLan2.Checked);
                        cmd.Parameters.AddWithValue("@Lan3", chbLan3.Checked);
                        cmd.Parameters.AddWithValue("@Stb", chbStb.Checked);
                        cmd.Parameters.AddWithValue("@AllagiKereas", chbChangeAntenna.Checked);
                        cmd.Parameters.AddWithValue("@AllagiLed", chbChangeLed.Checked);
                        cmd.Parameters.AddWithValue("@AllagiTrofodotiko", chbChangeSupply.Checked);
                        cmd.Parameters.AddWithValue("@AllagiKapaki", chbChangePlastic.Checked);
                        cmd.Parameters.AddWithValue("@AllagiVismatosTrofodosias", chbChangeSupplyInput.Checked);
                        cmd.Parameters.AddWithValue("@AllagiPackBox", chbPackBox.Checked);
                        cmd.Parameters.AddWithValue("@AllagiFirmware", chbFirmware.Checked);
                        cmd.Parameters.AddWithValue("@Paratiriseis", rtbNotes.Text.Trim());
                        if (rbtOk.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 1);
                        }
                        else if (rbtOff.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 2);
                        }
                        else if (rbtUpdate.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 3);
                        }
                        cmd.ExecuteNonQuery();
                        ClearForm();

                        GetModemsFromDB(DateTime.Today, DateTime.Today);
                    }
                }

                LoadDailyModems();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void UpdateTechModem()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateTechModem]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", ModemId);
                        cmd.Parameters.AddWithValue("@SerialNumber", txtSn.Text.Trim());
                        cmd.Parameters.AddWithValue("@Sap", int.Parse(cbxSap.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@UserId", ((frmMain)this.MdiParent).UserId);
                        cmd.Parameters.AddWithValue("@HmeromhniaElenxou", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Power", chbPower.Checked);
                        cmd.Parameters.AddWithValue("@Dsl", chbDsl.Checked);
                        cmd.Parameters.AddWithValue("@Internet", chbInternet.Checked);
                        cmd.Parameters.AddWithValue("@Wlan", chbWlan.Checked);
                        cmd.Parameters.AddWithValue("@Wps", chbWps.Checked);
                        cmd.Parameters.AddWithValue("@Lan1", chbLan1.Checked);
                        cmd.Parameters.AddWithValue("@Lan2", chbLan2.Checked);
                        cmd.Parameters.AddWithValue("@Lan3", chbLan3.Checked);
                        cmd.Parameters.AddWithValue("@Stb", chbStb.Checked);
                        cmd.Parameters.AddWithValue("@AllagiKereas", chbChangeAntenna.Checked);
                        cmd.Parameters.AddWithValue("@AllagiLed", chbChangeLed.Checked);
                        cmd.Parameters.AddWithValue("@AllagiTrofodotiko", chbChangeSupply.Checked);
                        cmd.Parameters.AddWithValue("@AllagiKapaki", chbChangePlastic.Checked);
                        cmd.Parameters.AddWithValue("@AllagiVismatosTrofodosias", chbChangeSupplyInput.Checked);
                        cmd.Parameters.AddWithValue("@AllagiPackBox", chbPackBox.Checked);
                        cmd.Parameters.AddWithValue("@AllagiFirmware", chbFirmware.Checked);
                        cmd.Parameters.AddWithValue("@Paratiriseis", rtbNotes.Text.Trim());
                        if (rbtOk.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 1);
                        }
                        else if (rbtOff.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 2);
                        }
                        else if (rbtUpdate.Checked)
                        {
                            cmd.Parameters.AddWithValue("@OkOffUpdate", 3);
                        }
                        cmd.ExecuteNonQuery();
                        ClearForm();

                        GetModemsFromDB(DateTime.Today, DateTime.Today);
                    }
                }

                LoadDailyModems();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ClearForm()
        {
            try
            {
                txtSn.Text = string.Empty;
                chbPower.Checked = false;
                chbDsl.Checked = false;
                chbInternet.Checked = false;
                chbWlan.Checked = false;
                chbWps.Checked = false;
                chbLan1.Checked = false;
                chbLan2.Checked = false;
                chbLan3.Checked = false;
                chbStb.Checked = false;
                chbChangeAntenna.Checked = false;
                chbChangeLed.Checked = false;
                chbChangeSupply.Checked = false;
                chbChangePlastic.Checked = false;
                chbChangeSupplyInput.Checked = false;
                chbFirmware.Checked = false;
                chbPackBox.Checked = false;
                rbtOk.Checked = false;
                rbtOff.Checked = false;
                rbtUpdate.Checked = false;
                rtbNotes.Text = string.Empty;
                lblErrSn.Visible = false;
                lblErrOkOffUpdate.Visible = false;
                Mode = Enums.SavingMode.Insert;
                HandleFormControls();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private bool ValidateInput()
        {
            bool isValid = true;
            lblErrSn.Visible = false;
            lblErrOkOffUpdate.Visible = false;

            try
            {
                if (string.IsNullOrEmpty(txtSn.Text.Trim()))
                {
                    isValid = false;
                    lblErrSn.Text = "*Το πεδίο είναι υποχρεωτικό μαλάκα.";
                    lblErrSn.Visible = true;
                }

                if (!rbtOk.Checked && !rbtOff.Checked && !rbtUpdate.Checked)
                {
                    isValid = false;
                    lblErrOkOffUpdate.Text = "*Το πεδίο είναι υποχρεωτικό μαλάκα.";
                    lblErrOkOffUpdate.Visible = true;
                }

                if (rbtOff.Checked && (chbChangeAntenna.Checked || chbChangeLed.Checked || chbChangeSupply.Checked || chbChangePlastic.Checked || chbChangeSupplyInput.Checked || chbFirmware.Checked || chbPackBox.Checked))
                {
                    isValid = false;
                    lblErrOkOffUpdate.Text = "*Αν το status είναι Off δεν επιτρέπεται η επιλογή κάποιου error ή fix.";
                    lblErrOkOffUpdate.Visible = true;
                }

                return isValid;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void LoadDailyModems()
        {
            getModemsBindingSource.DataSource = GetModemsFromDB(DateTime.Today, DateTime.Today);
        }

        private DataTable GetModemsFromDB(DateTime? dateFrom, DateTime? dateTo)
        {
            DataTable modemsDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetModems]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", ((frmMain)this.MdiParent).UserId);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", dateFrom);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", dateTo);
                        cmd.Parameters.AddWithValue("@serialNumber", txtSNSearch.Text.Trim());
                        cmd.Parameters.AddWithValue("@ordering", "HmeromhniaElenxou desc");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(modemsDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return modemsDT;
        }

        private void LoadModem(int modemId)
        {
            DataTable modemDT = GetModemFromDB(modemId);
            if (modemDT.Rows.Count > 0)
            {
                DataRow modem = modemDT.Rows[0];

                cbxSap.SelectedValue = modem["Sap"].ToString();
                txtSn.Text = modem["SerialNumber"].ToString();
                chbPower.Checked = bool.Parse(modem["Power"].ToString());
                chbDsl.Checked = bool.Parse(modem["Dsl"].ToString());
                chbInternet.Checked = bool.Parse(modem["Internet"].ToString());
                chbWlan.Checked = bool.Parse(modem["Wlan"].ToString());
                chbWps.Checked = bool.Parse(modem["Wps"].ToString());
                chbLan1.Checked = bool.Parse(modem["Lan1"].ToString());
                chbLan2.Checked = bool.Parse(modem["Lan2"].ToString());
                chbLan3.Checked = bool.Parse(modem["Lan3"].ToString());
                chbStb.Checked = bool.Parse(modem["Stb"].ToString());
                chbChangeAntenna.Checked = bool.Parse(modem["AllagiKereas"].ToString());
                chbChangeLed.Checked = bool.Parse(modem["AllagiLed"].ToString());
                chbChangeSupply.Checked = bool.Parse(modem["AllagiTrofodotiko"].ToString());
                chbChangePlastic.Checked = bool.Parse(modem["AllagiKapaki"].ToString());
                chbChangeSupplyInput.Checked = bool.Parse(modem["AllagiVismatosTrofodosias"].ToString());
                chbFirmware.Checked = bool.Parse(modem["AllagiPackBox"].ToString());
                chbPackBox.Checked = bool.Parse(modem["AllagiFirmware"].ToString());
                rbtOk.Checked = (modem["OkOffUpdate"].ToString() == "1") ? true : false;
                rbtOff.Checked = (modem["OkOffUpdate"].ToString() == "2") ? true : false;
                rbtUpdate.Checked = (modem["OkOffUpdate"].ToString() == "3") ? true : false;
                rtbNotes.Text = modem["Paratiriseis"].ToString();
            }
        }

        private DataTable GetModemFromDB(int id)
        {
            DataTable modemDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetModem]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(modemDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return modemDT;
        }

        private void HandleFormControls()
        {
            if (this.Mode == Enums.SavingMode.Insert)
            {
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else if (this.Mode == Enums.SavingMode.Update)
            {
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        #endregion

    }
}
