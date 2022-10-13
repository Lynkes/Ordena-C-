using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_OrdenaSegundaChava
{
    public partial class Form1 : Form
    {
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
                    dado = new Dado(gerador.Next(0, 1000000000), gerador.Next(0, 500));
                    lista.Add(dado);
                    textBox_dados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);
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
                openFileDialog1.Title = "Selecione o arquivo fonte com números chave1 e chave2";
                Dado dado;
                openFileDialog1.ShowDialog();
                string[] linhas = File.ReadAllLines(openFileDialog1.FileName);
                string[] numeros;
                for (int i = 0; i < linhas.Length; i++)
                {
                    numeros = linhas[i].Split(';');
                    dado = new Dado(int.Parse(numeros[0]), int.Parse(numeros[1]));
                    lista.Add(dado);
                    textBox_dados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);
                }
                textBox_qtdDados.Text = lista.Count.ToString();
                panel_algoritmo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na leitura do arquivo " + ex.Message);
            }
        }

        List<Dado> lista = new List<Dado>();

        private void button_aplicarAlgoritmo_Click(object sender, EventArgs e)
        {
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
                    if (checkedListBox1.CheckedItems[i].ToString() == "BOLHA2Chave")
                    {
                        sw.Start();
                        Ordena.bolha2aChave(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do BOLHA2Chave (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "bolha")
                    {
                        sw.Start();
                        Ordena.bolha(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do bolha (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "selecao")
                    {
                        sw.Start();
                        Ordena.selecao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do seleção (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "insercao")
                    {
                        sw.Start();
                        Ordena.insercao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do inserção (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "agitacao")
                    {
                        sw.Start();
                        Ordena.agitacao(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do agitação (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "pente")
                    {
                        sw.Start();
                        Ordena.pente(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do pente (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "shell")
                    {
                        sw.Start();
                        Ordena.shell(lista);
                        
                        sw.Stop();
                        textBoxTempo.AppendText("Fim do shell (ms): " + sw.ElapsedMilliseconds + Environment.NewLine);
                        exibirLista(lista);
                        sw.Reset();
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
                textBox_console.AppendText(item.Chave1 + " - " + item.Chave2 + Environment.NewLine);
            }
        }

        private static void textBox_algoritmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_console.Clear();
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
    }
}