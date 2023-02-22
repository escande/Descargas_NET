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
    public partial class frm_LecturaSimple : Form
    {
        public TrazabilidadMaterial material { get; set; }

        public frm_LecturaSimple()
        {
            InitializeComponent();

            GlobalSettings.MSCommNet._comm_DataReceive += DatosRecibidosEscaner;
        }

        
        private void frm_LecturaSimple_Load(object sender, EventArgs e)
        {
            material = new TrazabilidadMaterial();
            
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

        private void btnAceptarSi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(material.TrazabilidadMaterialesPPartNumber) && !string.IsNullOrEmpty(material.TrazabilidadMaterialesNAlbaran)
                                                                                    && !string.IsNullOrEmpty(material.TrazabilidadMaterialesSSerial)
                                                                                    && material.TrazabilidadMaterialesQCantidad.Value > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelarNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frm_LecturaSimple_FormClosing(object sender, FormClosingEventArgs e)
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
                            material.TrazabilidadMaterialesPPartNumber = Regex.Replace(cadena, @" ", "");
                            break;

                        case 'S':
                        case 'M':
                            material.TrazabilidadMaterialesSSerial = e.Lectura[1..];
                            break;

                        case 'Q':
                            material.TrazabilidadMaterialesQCantidad = int.Parse(e.Lectura[1..]);
                            break;

                        case 'A':
                        case 'N':
                            material.TrazabilidadMaterialesNAlbaran = e.Lectura[1..];
                            break;

                        case 'H':
                            material.TrazabilidadMaterialesHLote = e.Lectura[1..];
                            break;

                        case 'D':
                            material.TrazabilidadMaterialesDFecha = e.Lectura[1..];
                            break;

                        case 'V':
                            material.TrazabilidadMaterialesVProveedor = e.Lectura[1..];
                            break;

                        case 'B':
                            material.TrazabilidadMaterialesBEmbalaje = e.Lectura[1..];
                            break;

                        case '3':
                        case '4':
                            if (e.Lectura[0..1] == "4")
                            {
                                material.TrazabilidadMaterialesSSerial = e.Lectura[2..];
                            }
                            else if(e.Lectura[0..1] == "3")
                            {
                                if (e.Lectura[0..2] != "30")
                                {
                                    material.TrazabilidadMaterialesSSerial = e.Lectura[2..];
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

                    dgv.Rows[0].Cells["lectura"].Value = material.TrazabilidadMaterialesPPartNumber;
                    dgv.Rows[1].Cells["lectura"].Value = material.TrazabilidadMaterialesSSerial;
                    dgv.Rows[2].Cells["lectura"].Value = material.TrazabilidadMaterialesQCantidad;
                    dgv.Rows[3].Cells["lectura"].Value = material.TrazabilidadMaterialesNAlbaran;
                    dgv.Rows[4].Cells["lectura"].Value = material.TrazabilidadMaterialesHLote;
                    dgv.Rows[5].Cells["lectura"].Value = material.TrazabilidadMaterialesDFecha;
                    dgv.Rows[6].Cells["lectura"].Value = material.TrazabilidadMaterialesVProveedor;
                    dgv.Rows[7].Cells["lectura"].Value = material.TrazabilidadMaterialesBEmbalaje;
                }));
            }
            catch { }
        }

        private void tbManual_KeyPress(object sender, KeyPressEventArgs e)
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
