using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Descargas_NET.Helpers;
using Descargas_NET.Properties;

namespace Descargas_NET.Forms
{
    public partial class Frm_Config : Form
    {
        public Frm_Config()
        {
            InitializeComponent();
        }

        int PosX, PosY;
        public string ElParametro{ set; get; }
        private void Frm_Config_Load(object sender, EventArgs e)
        {
            lbTitulo.Text +=  "  " + ElParametro;
            CargarConfig();
        }

        private void CargarConfig()
        {
            string myParametro = ElParametro + "_";
            int x, n;
            
            SettingsPropertyCollection props = Settings.Default.Properties;
            foreach (SettingsProperty propItem in props)
            {
                string aux;
                //Console.WriteLine("PropName = {0} \t Default Value = {1}", propItem.Name, propItem.DefaultValue);
                //Console.WriteLine("Current value = {0}", Settings.Default.PropertyValues[propItem.Name].PropertyValue);
                //int x = propItem.Name.IndexOf("Serie_");
                //string a = 
                if (myParametro != "TODOS_")
                {
                    x = propItem.Name.ToUpper().IndexOf(myParametro);
                    if (x > -1)
                    {
                        n = propItem.Name.IndexOf("_");
                        aux = propItem.Name.Substring(n + 1);

                        if (!propItem.Name.ToLower().Contains("token"))
                        {
                            dgvMenu.Rows.Add(propItem.Name, aux, Settings.Default[propItem.Name].ToString());
                        }
                    }
                }
                else
                {
                    n = propItem.Name.IndexOf("_");
                    aux = propItem.Name.Substring(n + 1);

                    if (!propItem.Name.ToLower().Contains("token"))
                    {
                        dgvMenu.Rows.Add(propItem.Name, aux, Settings.Default[propItem.Name].ToString());
                    }
                }
            }

            if (dgvMenu.Rows.Count > 0)
            {
                DataGridViewColumn coll = dgvMenu.Columns[0];
                dgvMenu.Sort(coll, ListSortDirection.Ascending);
                dgvMenu.Rows[0].Cells[2].Selected = true;
            }
        }

        private void BtnAceptarSi_Click(object sender, EventArgs e)
        {
            string aux;
            try
            {


                DialogResult dialogResult = Aviso.Msg("¿Deseas guardar los cambios realizados en la configuración?\n"
                    +"Se deberé resetear la aplicación para que surjan efecto los cambios!!!", true);
                if (dialogResult == DialogResult.OK)
                {
                    SettingsPropertyCollection props = Settings.Default.Properties;


                    foreach (DataGridViewRow dvr in dgvMenu.Rows)
                    {
                        aux = dvr.Cells[0].Value.ToString();

                        foreach (SettingsProperty propItem in props)
                        {
                            if (aux == propItem.Name)
                            {
                                var valor = dvr.Cells[2].Value;
                                var pType = propItem.PropertyType.Name;

                                switch (pType)
                                {
                                    case "Int32":
                                        valor = Convert.ToInt32(valor);
                                        break;

                                    case "Boolean":
                                        valor = Convert.ToBoolean(valor);
                                        break;

                                    case "Byte":
                                        valor = Convert.ToByte(valor);
                                        break;

                                    default:
                                        break;
                                }
                                Settings.Default[aux] = valor;
                                Settings.Default.Save();
                            }
                        }
                    }

                    //CargarConfigClass();
                    this.Close();
                }
            }
            catch (Exception ex)
            { Aviso.Msg("Se ha producido el siguiente error: \n" + ex.Message, false); }
        }

        //private void CargarConfigClass()
        //{
        //    //frm_Principal.f1.ComunicacionDevices.ComWebApi.Url = Settings.Default.Api_WEBAPI_URL;
        //    //frm_Principal.f1.ComunicacionDevices.ComWebApi.User = Settings.Default.Api_WEBAPI_User;
        //    //frm_Principal.f1.ComunicacionDevices.ComWebApi.Password = Settings.Default.Api_WEBAPI_Password;
        //    //frm_Principal.f1.ComunicacionDevices.ComWebApi.Token = Settings.Default.Api_WEBAPI_Token;

        //    //frm_Principal.f1.ComunicacionDevices.ComHKVision.IP = Settings.Default.HK_Controladora_IP;
        //    //frm_Principal.f1.ComunicacionDevices.ComHKVision.Port = Settings.Default.HK_Controladora_Port;
        //    //frm_Principal.f1.ComunicacionDevices.ComHKVision.User = Settings.Default.HK_Controladora_User;
        //    //frm_Principal.f1.ComunicacionDevices.ComHKVision.Password = Settings.Default.HK_Controladora_Password;
        //}

        private DataTable RecuperarParametros()
        {
            string myParametro = ElParametro + "_";
            int x, n;

            try
            {
                DataTable dt = new DataTable("Settings");
                DataColumn Nombre = new DataColumn("Nombre");
                DataColumn Setting = new DataColumn("Setting");
                DataColumn Valor = new DataColumn("Valor");

                dt.Columns.Add(Nombre);
                dt.Columns.Add(Setting);
                dt.Columns.Add(Valor);

                SettingsPropertyCollection props = Settings.Default.Properties;
                foreach (SettingsProperty propItem in props)
                {
                    DataRow dr;
                    string aux;
                    if (myParametro != "TODOS_")
                    {
                        x = propItem.Name.ToUpper().IndexOf(myParametro);
                        if (x > -1)
                        {
                            n = propItem.Name.IndexOf("_");
                            aux = propItem.Name.Substring(n + 1);

                            dr = dt.NewRow();
                            dr["Nombre"] = aux;
                            dr["Setting"] = propItem.Name;
                            dr["Valor"] = Settings.Default[propItem.Name].ToString();
                            dt.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        n = propItem.Name.IndexOf("_");
                        aux = propItem.Name.Substring(n + 1);

                        dr = dt.NewRow();
                        dr["Nombre"] = aux;
                        dr["Setting"] = propItem.Name;
                        dr["Valor"] = Settings.Default[propItem.Name].ToString();
                        dt.Rows.Add(dr);
                    }
                }

                return dt;
            }
            catch
            { return null; }
        }

        private void BtnCancelarNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            PosX = e.X;
            PosY = e.Y;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            DataTable myDt = new DataTable();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de configuración (*.cfg)|*.cfg"
            };

            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                myDt.ReadXml(saveFileDialog.FileName);
                dgvMenu.Rows.Clear();

                CargarDatoxXml(myDt);
            }
        }

        private void CargarDatoxXml(DataTable _dt)
        {
            string myParametro = ElParametro + "_";
            int x;

            try
            {
                SettingsPropertyCollection props = Settings.Default.Properties;
                //dgvMenu.Rows.Clear();

                foreach (DataRow dr in _dt.Rows)
                {
                    string row = dr["Setting"].ToString();

                    foreach (SettingsProperty propItem in props)
                    {
                        if (myParametro != "TODOS_")
                        {
                            x = propItem.Name.IndexOf(myParametro);
                            if (x > -1)
                            {
                                //n = propItem.Name.IndexOf("_");
                                //aux = propItem.Name.Substring(n + 1);

                                if (propItem.Name == row)
                                {
                                    dgvMenu.Rows.Add(dr["Setting"].ToString(), dr["Nombre"].ToString(), dr["Valor"].ToString());                                    
                                }
                            }
                        }
                        else
                        {
                            if (row == propItem.Name)
                            {
                                //n = propItem.Name.IndexOf("_");
                                //aux = propItem.Name.Substring(n + 1);
                                dgvMenu.Rows.Add(dr["Setting"].ToString(), dr["Nombre"].ToString(), dr["Valor"].ToString());
                            }
                        }
                    }
                }

                //if (dgvMenu.Rows.Count > 0)
                //{
                //    DataGridViewColumn coll = dgvMenu.Columns[0];
                //    dgvMenu.Sort(coll, ListSortDirection.Ascending);
                //    dgvMenu.Rows[0].Cells[2].Selected = true;
                //}
            }
            catch (Exception ex)
            {
                Aviso.Msg("ERROR Cargando config - " + ex.Message, false);

            }

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable myDt = RecuperarParametros();

            if (myDt != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivo de configuración (*.cfg)|*.cfg"
                };

                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    myDt.WriteXml(saveFileDialog.FileName, XmlWriteMode.WriteSchema);
                }
            }
        }

        private void DgvMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMenu.Columns[e.ColumnIndex].Index == 1 && e.Value != null)
            {
                var name = e.Value.ToString();
                if(name.ToLower().Contains("password"))
                {
                    //var valor = dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dgvMenu.Rows[e.RowIndex].Cells[2].Value = new String('*', e.Value.ToString().Length);
                }
                //studentGridView.Rows[e.RowIndex].Tag = e.Value;
                //e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void LbTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            int l;
            int t;
            l = this.Left;
            t = this.Top;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = (l + e.X) - PosX;
                this.Top = (t + e.Y) - PosY;
            }
        }
    }
}
