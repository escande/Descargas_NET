using Descargas_NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Descargas_NET.Forms
{
    public partial class frm_DescargaResumen : Form
    {
        private readonly List<TrazabilidadMaterial> _materiales;

        public frm_DescargaResumen(List<TrazabilidadMaterial> materiales)
        {
            InitializeComponent();
            this._materiales = materiales;
        }

        private void frm_DescargaResumen_Load(object sender, EventArgs e)
        {
            MostrarResumen();
        }

        private void MostrarResumen()
        {
            try
            {
                var materialResumen = _materiales.GroupBy(x => x.TrazabilidadMaterialesReferenciaSap, 
                                                            x => x.TrazabilidadMaterialesPPartNumber,
                                                            (z, y)=> new 
                                                            {
                                                                Key = z,
                                                                pn = y,
                                                                count = y.Count()
                                                            });

                int i = 0;
                foreach(var item in materialResumen)
                {
                    var hayAlerta = _materiales.Any(x => x.TrazabilidadMaterialesReferenciaSap == item.Key && x.AvisoCDMId > 0);
                    var hayMsg = _materiales.Any(x => x.TrazabilidadMaterialesReferenciaSap == item.Key && x.AvisoCarretilleroCDMId > 0);

                    dgv.Rows.Add();
                    dgv.Rows[i].Cells["SAP"].Value = item.Key;
                    dgv.Rows[i].Cells["PN"].Value = item.pn.FirstOrDefault();
                    dgv.Rows[i].Cells["Cantidad"].Value = item.count;

                    if (hayAlerta || hayMsg)
                    {
                        for (int cell = 0; cell < dgv.Rows[i].Cells.Count; cell++)
                        {

                            dgv.Rows[i].Cells[cell].Style.BackColor = hayAlerta ? Color.Yellow : Color.Orange;
                        }
                    }

                    i++;
                }
            }
            catch
            {

            }
        }
        private void btnAceptarSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
