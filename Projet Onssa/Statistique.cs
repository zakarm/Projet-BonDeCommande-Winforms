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
using LiveCharts.Wpf;
using LiveCharts;

namespace Projet_Onssa
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {

            try
            {
                label_mounth.Text = "du mois " + DateTime.Today.Month.ToString();
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query1 = from bc in ctx.BCSet
                                 where bc.DateBC.Month.Equals(DateTime.Today.Month)
                                 select bc;
                    label_NumBcMounth.Text = query1.Count().ToString();

                    var query2 = from cmpt in ctx.GestionCompteSet
                                 select cmpt;
                    label_Compte.Text = query2.Count().ToString();


                    //var query3 = from bc in ctx.BCSet
                    //             join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                    //             join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                    //             m.InfoFournisseur.IdFournisseur
                    //             where m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                    //             select new
                    //             {
                    //                 Year = m.Date.Year,
                    //                 Mounth = m.Date.Month,
                    //                 Ttc = m.Ttc,

                    //             };
                    //dataGridView1.DataSource = query3.ToList();






                    using (SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Onssa_Db.mdf;Integrated Security=True;Connect Timeout=30"))
                    {


                        SqlCommand testCMD = new SqlCommand("sp_spaceused", Conn);
                        testCMD.CommandType = CommandType.StoredProcedure;
                        Conn.Open();
                        SqlDataReader reader = testCMD.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                label_taille.Text = reader["database_size"].ToString();
                            }
                        }
                        Conn.Close();
                    }

                    
                    LiveCharts.Wpf.Axis a = new LiveCharts.Wpf.Axis
                    {
                        Title = "Mois",
                        Labels = new[] { "Jan", "Fev", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec" },
                    };

                    cartesianChart.AxisX.Add(a);
                    a.FontSize = 16;
                    a.FontStyle = System.Windows.FontStyles.Italic;
                    cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;


                    LiveCharts.Wpf.Axis c = new LiveCharts.Wpf.Axis
                    {
                        Title = "Ttc",
                        LabelFormatter = value => value.ToString("C"),
                    };
                    cartesianChart.AxisY.Add(c);
                    c.FontSize = 16;
                    c.FontStyle = System.Windows.FontStyles.Italic;
                    cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;

                    cartesianChart.Series.Clear();
                    SeriesCollection series = new SeriesCollection();
                   
                    var years = from bc in ctx.BCSet
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new { Year = bc.DateBC.Year};

                    foreach (var year in years)
                    {
                        List<double> values = new List<double>();

                        for (int month = 1; month <= 12; month++)
                        {
                            double valueD = 0;
                            var data = from bc in ctx.BCSet
                                       join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                       join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                       m.InfoFournisseur.IdFournisseur
                                       where m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation && bc.DateBC.Year.Equals(year.Year) && month.Equals(bc.DateBC.Month)
                                       orderby bc.DateBC.Month ascending
                                       select m;

                           

                            if (data.FirstOrDefault() != null)
                            {
                                valueD = data.AsEnumerable().Sum(o => o.Ttc);

                            }
                            else
                            {
                                valueD = 0;

                            }
                            values.Add(valueD);
                        }
                        series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values)});
                        cartesianChart.Series = series;
                    }
                    
                }
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        
    }
}
