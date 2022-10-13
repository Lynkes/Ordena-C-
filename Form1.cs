using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_OrdenaSegundaChava
{
    public partial class Form1 : Form
    {
        List<Dado> lista = new List<Dado>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_gerar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            textBox_dados.Clear();
            Random gerador = new Random();
            try
            {
                long qtdNumeros = long.Parse(textBox_qtdDados.Text);
                Dado dado;
                for (; qtdNumeros > 0; qtdNumeros--)
                {
                    dado = new Dado(gerador.Next(0, 1000000000));
                    lista.Add(dado);
                    textBox_dados.AppendText(dado.Chave1 + Environment.NewLine);
                }
                textBox_qtdDados.Text = "";
                panel_algoritmo.Enabled = true;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Tipo inválido", "Alerta");
                textBox_qtdDados.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Confira seus dados no text box", "Alerta");
                textBox_qtdDados.Text = "";
            }
        }

        private void button_abrirArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                textBox_dados.Clear();
                OpenFileDialog openFileDialog1;
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Title = "Selecione o arquivo fonte com números chave";
                Dado dado;
                openFileDialog1.ShowDialog();
                string[] linhas = File.ReadAllLines(openFileDialog1.FileName);
                string[] numeros;
                for (int i = 0; i < linhas.Length; i++)
                {
                    numeros = linhas;
                    dado = new Dado(int.Parse(numeros[0]));
                    lista.Add(dado);
                    textBox_dados.AppendText(dado.Chave1 + Environment.NewLine);
                }
                textBox_qtdDados.Text = lista.Count.ToString();
                panel_algoritmo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na leitura do arquivo " + ex.Message);
            }
        }

        



        private void button_aplicarAlgoritmo_Click(object sender, EventArgs e)
        {

            List<Dado> lista2 = lista.ConvertAll(lista => new Dado(lista.Chave1));
            Stopwatch sw = new Stopwatch();
            //BOLHA2Chave
            //bolha
            //selecao
            //insercao
            //agitacao
            //pente
            //shell
            //posicionaPivo
            //quick
            //heapSort
            //lista.SortMS


            // verifica se existem itens marcados
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // percorre todos os itens marcados
                // e verifica se um item especifico foi marcado
                for (int i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                {
                    List<Dado> lista = lista2.ConvertAll(lista2 => new Dado(lista2.Chave1));
                    if (checkedListBox1.CheckedItems[i].ToString() == "bolha")
                    {
                        exibirLista2(lista);
                        textBox_console2.AppendText("Fim bolha lista Orig" + Environment.NewLine);
                        sw.Start();
                        
                        Ordena.bolha(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do bolha (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim bolha" + Environment.NewLine);
                        
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "selecao")
                    {
                        exibirLista2(lista);
                        textBox_console2.AppendText("Fim seleção lista Orig" + Environment.NewLine);
                        sw.Start();
                        Ordena.selecao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do seleção (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim seleção" + Environment.NewLine);
                        
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "insercao")
                    {
                        exibirLista2(lista);
                        textBox_console2.AppendText("Fim inserção lista Orig" + Environment.NewLine);
                        sw.Start();
                        Ordena.insercao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do inserção (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim inserção" + Environment.NewLine);
                        
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "agitacao")
                    {
                        exibirLista2(lista);
                        textBox_console2.AppendText("Fim agitação lista Orig" + Environment.NewLine);
                        sw.Start();
                        Ordena.agitacao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do agitação (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim agitação" + Environment.NewLine);
                        
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "pente")
                    {
                        exibirLista2(lista2);
                        textBox_console2.AppendText("Fim pente lista Orig" + Environment.NewLine);
                        sw.Start();
                        Ordena.pente(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do pente (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim pente" + Environment.NewLine);
                        
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "shell")
                    {
                        exibirLista2(lista);
                        textBox_console2.AppendText("Fim shell lista Orig" + Environment.NewLine);
                        sw.Start();
                        Ordena.shell(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do shell (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        sw.Reset();
                        exibirLista(lista);
                        textBox_console.AppendText("Fim shell" + Environment.NewLine);
                        
                    }
                    //if (checkedListBox1.CheckedItems[i].ToString() == "heapSort")
                    //{
                    //    sw.Start();
                    //    Ordena.heapSort(lista);
                    //    exibirLista(lista);
                    //    sw.Stop();
                    //    MessageBox.Show("Fim do heapSort (ms): " + sw.ElapsedMilliseconds);
                    //    textBoxTempo.AppendText("Fim do heapSort (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                    //    sw.Reset();
                    //}
                    //if (checkedListBox1.CheckedItems[i].ToString() == "lista.SortMS")
                    //{
                    //    sw.Start();
                    //    lista.Sort();
                        
                    //    sw.Stop();
                    //    textBoxTempo.AppendText("Fim do lista.SortMS (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                    //    exibirLista(lista);
                    //    sw.Reset();
                    //}
                }
            }
        }

        private void exibirLista(List<Dado> lista)
        {
            foreach (var item in lista)
            {
                textBox_console.AppendText(item.Chave1 + Environment.NewLine);
            }
        }

        private void exibirLista2(List<Dado> lista)
        {
            foreach (var item in lista)
            {
                textBox_console2.AppendText(item.Chave1 + Environment.NewLine);
            }
        }


        private static void textBox_algoritmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_console.Clear();
            textBox_console2.Clear();
            panel_algoritmo.Enabled = false;
        }

        private void textBox_qtdDados_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_console_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}