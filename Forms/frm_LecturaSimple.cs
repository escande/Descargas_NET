using Descargas_NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class Frm_LecturaSimple : Form
    {
        public TrazabilidadMaterial Material { get; set; }

        public Frm_LecturaSimple()
        {
            InitializeComponent();

            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
        }

        
        private void Frm_LecturaSimple_Load(object sender, EventArgs e)
        {
            Material = new TrazabilidadMaterial();
            
            dgv.Rows.Add();
            dgv.Rows[0].Cells["campo"].Value = "Campo P";
            dgv.Rows[0].Cells[0].Style.BackColor = Color.Green;
            dgv.Rows.Add();
            dgv.Rows[1].Cells["campo"].Value = "Campo S";
            dgv.Rows[1].Cells[0].Style.BackColor = Color.Green;
            dgv.Rows.Add();
            dgv.Rows[2].Cells["campo"].Value = "Campo Q";
            dgv.Rows[2].Cells[0].Style.BackColor = Color.Green;
            dgv.Rows.Add();
            dgv.Rows[3].Cells["campo"].Value = "Campo N";
            dgv.Rows[3].Cells[0].Style.BackColor = Color.Green;
            dgv.Rows.Add();
            dgv.Rows[4].Cells["campo"].Value = "Campo H";
            dgv.Rows.Add();
            dgv.Rows[5].Cells["campo"].Value = "Campo D";
            dgv.Rows.Add();
            dgv.Rows[6].Cells["campo"].Value = "Campo V";
            dgv.Rows.Add();
            dgv.Rows[7].Cells["campo"].Value = "Campo B";
            dgv.Rows[0].Cells[1].Selected = true;
        }

        private void BtnAceptarSi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Material.TrazabilidadMaterialesPPartNumber) && !string.IsNullOrEmpty(Material.TrazabilidadMaterialesNAlbaran)
                                                                                    && !string.IsNullOrEmpty(Material.TrazabilidadMaterialesSSerial)
                                                                                    && Material.TrazabilidadMaterialesQCantidad.Value > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancelarNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_LecturaSimple_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.MSCommNet._comm_DataReceive -= DatosRecibidosEscaner;
        }

        private void DatosRecibidosEscaner(LecturaOdette e)
        {
            try
            {
                if (e.CodeType == CodeType.Code1D)
                {
                    switch (e.Lectura[0])
                    {
                        case 'P':
                            var cadena = e.Lectura[1..];
                            Material.TrazabilidadMaterialesPPartNumber = Regex.Replace(cadena, @" ", "");
                            break;

                        case 'S':
                        case 'M':
                        case 'A':
                            Material.TrazabilidadMaterialesSSerial = e.Lectura[1..];
                            break;

                        case 'Q':
                            Material.TrazabilidadMaterialesQCantidad = int.Parse(e.Lectura[1..]);
                            break;

                        case 'N':
                            Material.TrazabilidadMaterialesNAlbaran = e.Lectura[1..];
                            break;

                        case 'H':
                            Material.TrazabilidadMaterialesHLote = e.Lectura[1..];
                            break;

                        case 'D':
                            Material.TrazabilidadMaterialesDFecha = e.Lectura[1..];
                            break;

                        case 'V':
                            Material.TrazabilidadMaterialesVProveedor = e.Lectura[1..];
                            break;

                        case 'B':
                            Material.TrazabilidadMaterialesBEmbalaje = e.Lectura[1..];
                            break;

                        case '3':
                        case '4':
                            if (e.Lectura[0..1] == "4")
                            {
                                Material.TrazabilidadMaterialesSSerial = e.Lectura[2..];
                            }
                            else if(e.Lectura[0..1] == "3")
                            {
                                if (e.Lectura[0..2] != "30")
                                {
                                    Material.TrazabilidadMaterialesSSerial = e.Lectura[2..];
                                }
                            }

                            break;
                    }

                    RellenarGrid(e.Lectura);
                }
            }
            catch { }
        }

        private void RellenarGrid(string lectura)
        {
            try
            {
                dgv.BeginInvoke(new Action(() =>
                {
                    lbLectura.Text = lectura;

                    dgv.Rows[0].Cells["lectura"].Value = Material.TrazabilidadMaterialesPPartNumber;
                    dgv.Rows[1].Cells["lectura"].Value = Material.TrazabilidadMaterialesSSerial;
                    dgv.Rows[2].Cells["lectura"].Value = Material.TrazabilidadMaterialesQCantidad;
                    dgv.Rows[3].Cells["lectura"].Value = Material.TrazabilidadMaterialesNAlbaran;
                    dgv.Rows[4].Cells["lectura"].Value = Material.TrazabilidadMaterialesHLote;
                    dgv.Rows[5].Cells["lectura"].Value = Material.TrazabilidadMaterialesDFecha;
                    dgv.Rows[6].Cells["lectura"].Value = Material.TrazabilidadMaterialesVProveedor;
                    dgv.Rows[7].Cells["lectura"].Value = Material.TrazabilidadMaterialesBEmbalaje;
                }));
            }
            catch { }
        }

        private void TbManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var lectura = new LecturaOdette { Lectura = tbManual.Text.ToUpper() };
                tbManual.Text = "";
                DatosRecibidosEscaner(lectura);
            }
        }
    }
}
