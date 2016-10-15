using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisOrganizador
{
    public partial class FormOrganizador : Form
    {
        public FormOrganizador()
        {
            InitializeComponent();
            carregarConfig();
        }

        private void btOrigem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog origem = new FolderBrowserDialog();
            origem.ShowDialog();
            tbOrigem.Text = origem.SelectedPath;
        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destino = new FolderBrowserDialog();
            destino.ShowDialog();
            tbDestino.Text = destino.SelectedPath;
        }

        private void salvarConfig()
        {
            try
            {
                Properties.Settings.Default.PastaOrigem = tbOrigem.Text;
                Properties.Settings.Default.PastaDestino = tbDestino.Text;
                Properties.Settings.Default.Intervalo = Convert.ToInt16(tbIntervalo.Text);

            }
            catch (IOException ex)
            {
                //status
                statusBar.Text = "Status:" + ex.Message;

            }

        }
        private void carregarConfig()
        {
            tbOrigem.Text = Properties.Settings.Default.PastaOrigem;
            tbDestino.Text = Properties.Settings.Default.PastaDestino;
            tbIntervalo.Text = Properties.Settings.Default.Intervalo.ToString();

        }

        private void mnuSalvarConfig_Click(object sender, EventArgs e)
        {
            salvarConfig();
        }

        private void carregarConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carregarConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;

            lblStatus.Text = "Tarefa iniciada.";

            var origem = @tbOrigem.Text;
            var destino = @tbDestino.Text;
            var extensao = @mskExtensao.Text;

            //Task.Factory.StartNew ( () => work(origem, destino, extensao) );
            //Task.Run(() => work(origem, destino, extensao));

            lblStatus.Text = "Organizando arquivos...";

            Task t = new Task(() => work(origem, destino, extensao));
            t.RunSynchronously();
            
            if (t.IsCompleted)
            {
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Value = 0;
                lblStatus.Text = "Arquivos organizados.";
            } 
        }

        private  void  work(String origem, String destino, String extensao)
        {

            var f = Directory.GetFiles(origem, extensao);

            progressBar.Maximum = f.Count();
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            string padrao = @"[0-9]{14}";

            var data = "";
            //var hora = "";
            
            foreach (var s in f)
            {

                Regex r = new Regex(padrao, RegexOptions.IgnoreCase);
                var m = r.Match(s);
                
                if (m.Success)
                {
                    
                    data = m.Value.Substring(0, 8);
                    //hora = m.Value.Substring(8, 6);

                    var dir = @origem + "/" + data;

                    if (!Directory.Exists(dir))
                    {
                        lblStatus.Text = "Criando diretório " + dir;
                        Directory.CreateDirectory(dir);
                    }
                    var arquivo_destino = Path.GetFileName(s);
                    lblStatus.Text = String.Format("Organizando arquivo {0} ", Path.GetFileName(s));
                    File.Copy(s, dir + "/" + arquivo_destino);

                
                    progressBar.Value++;
                    

                }
                else
                    Console.WriteLine("Nome do diretório: {0} não tem o  padrão. ", s);
            }
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
