using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.ProgramacaoAssincrona
{
    public partial class frmAsync : Form
    {

        private static CancellationTokenSource cancellationTokenSource;
        public frmAsync()
        {
            InitializeComponent();
        }

        private async void btnAssincrono_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "Iniciando café da manhã...\n";

            // Inicia as tarefas sem esperar
            var tarefaPrepararCafe = PrapararCafe();
            var tarefaPrepararPao = PrapararPao();

            // Aguarda ambas ao mesmo tempo
            var cafe = await tarefaPrepararCafe;
            var pao = await tarefaPrepararPao;

            txtEditor.Text += "Serviu o café da manhã...\n";


            await MetodoSemRetornoAsync();
            var resultado = await MetodoRetornaValorAsync(10);

            Task task = Task.Run(() =>
            {

                for (int i = 0; i < 5; i++)
                {
                    Task.Delay(1000).Wait();
                }

            });


            //Cancelamento de tarefas=============


            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.Cancel();

                var canc = await OperacaoLongaDuracaoCancelavel(100,
                    cancellationTokenSource.Token);

                await ExecutaCancelamentoComTimeOut(2500);
                await ExecutaCancelamentoComTimeOut2(2500);

            }
            catch (Exception)
            {
                throw;
                string erro = $"Tempo expirado após {stopwatch.Elapsed}";
            }

            stopwatch.Stop();

        }

        public Task<Cafe> PrapararCafe()
        {
            Cafe cafe = new Cafe();
            cafe.Marca = "Café Pilão";
            txtEditor.Text += "Esquentando a água do café...\n";
            txtEditor.Text += $"Coando o café : {cafe.Marca} ...\n";
            txtEditor.Text += $"Servindo o café ...\n";

            return Task.FromResult(cafe);
        }

        public Task<Pao> PrapararPao()
        {
            Pao pao = new Pao();
            pao.Tipo = "Pão Francês";
            txtEditor.Text += $"Cortando o pão:  {pao.Tipo}...\n";
            txtEditor.Text += $"Passando manteiga no pão ...\n";
            txtEditor.Text += $"Servindo o pão...\n";

            return Task.FromResult(pao);
        }


        static async ValueTask MetodoSemRetornoAsync()
        {
            await Task.Delay(2000);
        }


        static async ValueTask<int> MetodoRetornaValorAsync(int valor)
        {
            await Task.Delay(2000);
            return valor * 2;
        }


        private static Task<int> OperacaoLongaDuracaoCancelavel(int valor,
            CancellationToken cancellationToken = default)
        {
            Task<int> task = null;
            task = Task.Run(async () =>
            {
                int resultado = 0;
                for (int i = 0; i < valor; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(task);

                    await Task.Delay(50); // não bloqueia a thread
                    resultado += i;
                }
                return resultado;
            });

            return task;
        }

        public static async Task ExecutaCancelamentoComTimeOut(int tempo)
        {
            using (var cts = new CancellationTokenSource(tempo))
            {
                try
                {
                    var resultado = await OperacaoLongaDuracaoCancelavel(100,
                        cancellationTokenSource.Token);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static async Task ExecutaCancelamentoComTimeOut2(int tempo)
        {
            using (var cts = new CancellationTokenSource())
            {
                cts.CancelAfter(tempo);

                try
                {
                    var resultado = await OperacaoLongaDuracaoCancelavel(100,
                        cancellationTokenSource.Token);
                }
                catch (TaskCanceledException)
                {
                    throw;
                }
            }
        }

        private void Excecoes_Click(object sender, EventArgs e)
        {
            TesteAsync t = new();

            try
            {
                t.ChamadaTarefaAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Metodo não será executado");
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MultiplasExcecoesAsync t = new();
             await t.LancaMultiplasExcecoesAsync();
        }
    }

    public class Cafe
    {
        public string Marca { get; set; }
    }

    public class Pao
    {
        public string Tipo { get; set; }
    }

}
