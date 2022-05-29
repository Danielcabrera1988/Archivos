using System;
using System.IO;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtBoxRuta.Text = fbd.SelectedPath;
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (txtBoxRuta.Text != "")
            {
                DirectoryInfo dir = new DirectoryInfo(@txtBoxRuta.Text);
                FileInfo[] Files = dir.GetFiles("*." + cmbBoxExt.Text, SearchOption.AllDirectories);
                DirectoryInfo[] dirs = dir.GetDirectories("*", SearchOption.AllDirectories);//muestra todas las subcarpetas de la carpeta seleccionada y las subcarpetas de las subcarpetas
                double[] tamArch = new double[Files.Length];
                int i = 0, cont = 0;
                double sumador = 0;
                //cargamos las demás carpetas encontradas dentro de la carpeta seleccionada
                foreach (var directory in dirs)
                {
                    listBoxDir.Items.Add(directory.Name);
                }

                //cargamos los archivos en los listbox
                foreach (var file in Files)
                {
                    listBoxNombre.Items.Add(file.Name);
                    tamArch[i] = file.Length;
                    i++;
                }
                //calculamos el tamaño de cada archivo pasandolo a KB y cargando al listbox
                for (int k = 0; k < tamArch.Length; k++)
                {
                    sumador += tamArch[k];
                    tamArch[k] /= 1042;
                    listBoxTam.Items.Add(tamArch[k].ToString("0.00") + " KB");
                    cont++;
                }
                sumador /= 1042;//pasamos a kb el total de los archivos
                //calculamos el porcentaje del total de cada archivo
                for (int j = 0; j < tamArch.Length; j++)
                {
                    tamArch[j] = (tamArch[j] * 100) / sumador;
                    listBoxRelativo.Items.Add(tamArch[j].ToString("0.00") + "%");
                }
                //mostramos los resultados de tamaño total y de cuantos archivos tienen la extensión seleccionada
                lblCantArch.Text = cont.ToString();
                lblTamTotal.Text = sumador.ToString("0.00") + " KB";//muestra el tamaño total en KB                                
            }
            else
            {
                MessageBox.Show("No hay una ruta especificada del directorio");
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            sFD.Filter = "Archivos JSON|*.json" + "|Archivos XML|*.xml" + "|Archivos TXT|*.txt";
            if (listBoxNombre.Items.Count > 0)
            {
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir = new DirectoryInfo(@txtBoxRuta.Text);
                    FileInfo[] Files = dir.GetFiles("*." + cmbBoxExt.Text, SearchOption.AllDirectories);//obtiene todos los archivos de la carpeta seleccionada con la extensión seleccionada
                    DirectoryInfo[] dirs = dir.GetDirectories("*", SearchOption.AllDirectories);//graba todas las subcarpetas de la carpeta seleccionada y las subcarpetas de las subcarpetas
                    FileStream fileStream = new FileStream(@sFD.FileName, FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        double[] tamArch = new double[Files.Length];
                        int i = 0, cont = 0;
                        double sumador = 0;
                        //cargamos las demás carpetas encontradas dentro de la carpeta seleccionada
                        foreach (var directory in dirs)
                        {
                            writer.WriteLine("Dir: " + directory.Name);
                        }
                        //cargamos los archivos en los listbox
                        foreach (var file in Files)
                        {
                            writer.WriteLine("Ar: " + file.Name);
                            tamArch[i] = file.Length;
                            i++;
                        }
                        //calculamos el tamaño de cada archivo pasandolo a KB y cargando al listbox
                        for (int k = 0; k < tamArch.Length; k++)
                        {
                            sumador += tamArch[k];
                            tamArch[k] /= 1042;
                            writer.WriteLine("T " + tamArch[k].ToString("0.00") + " KB");
                            cont++;
                        }
                        sumador /= 1042;//pasamos a kb el total de los archivos
                        //calculamos el porcentaje del total de cada archivo
                        for (int j = 0; j < tamArch.Length; j++)
                        {
                            tamArch[j] = (tamArch[j] * 100) / sumador;
                            writer.WriteLine("P " + tamArch[j].ToString("0.00") + "%");
                        }
                        //mostramos los resultados de tamaño total y de cuantos archivos tienen la extensión seleccionada
                        writer.WriteLine("Cantidad de Archivos: " + cont.ToString());
                        writer.WriteLine("Tamaño total de Archivos encontrados: " + sumador.ToString("0.00") + " KB");
                    }
                    fileStream.Close();
                }
                else sFD.Dispose();
            }
            else
            {
                MessageBox.Show("No hay datos para guardar un archivo");
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxDir.Items.Clear();
            listBoxNombre.Items.Clear();
            listBoxRelativo.Items.Clear();
            listBoxTam.Items.Clear();
            lblCantArch.Text = "";
            lblTamTotal.Text = "";
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            oFD.Reset();
            oFD.Filter = "Archivos Json|*.json" + "|Archivos XML|*.xml" + "|Archivos TXT|*.txt";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(oFD.FileName, FileMode.Open);
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Dir: "))
                        {
                            listBoxDir.Items.Add(line.Substring(5));
                        }
                        else if (line.Contains("Ar: "))
                        {
                            listBoxNombre.Items.Add(line.Substring(4));
                        }
                        else if (line.Contains("T "))
                        {
                            listBoxTam.Items.Add(line.Substring(2));
                        }
                        else if (line.Contains("P "))
                        {
                            listBoxRelativo.Items.Add(line.Substring(2));
                        }
                        else if (line.Contains("Cantidad de Archivos: "))
                        {
                            lblCantArch.Text = line.Substring(22);
                        }
                        else if (line.Contains("Tamaño total de Archivos encontrados: "))
                        {
                            lblTamTotal.Text = line.Substring(38);
                        }
                    }
                }
            }
            else oFD.Dispose();
        }
    }
}